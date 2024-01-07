using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.IO;

namespace Power_Point
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();

        private const string LINE = "Line";
        private const string RECTANGLE = "Rectangle";
        private const string CIRCLE = "Circle";
        private const string POINTER = "Pointer";
        const string APPLICATION_NAME = "Power_Point";
        const string CLIENT_SECRET_FILE_NAME = "clientSecret.json";

        private Pages _pages;
        private int _currentPageIndex; 
        private IState _state;
        private PointState _pointState;
        private LineState _lineState;
        private RectangleState _rectangleState;
        private CircleState _circleState;
        private CommandManager _commandManager;
        GoogleDriveService _service;

        public Model()
        {
            _pages = new Pages();
            _currentPageIndex = 0;

            _pointState = new PointState(this);
            _lineState = new LineState(this);
            _rectangleState = new RectangleState(this);
            _circleState = new CircleState(this);
            // 預設 Point State
            _state = _pointState;
            _commandManager = new CommandManager();
            _service = new GoogleDriveService(APPLICATION_NAME, CLIENT_SECRET_FILE_NAME);
        }

        // binding DataGridView 所需屬性
        public BindingList<Shape> Shapes
        {
            get
            {
                return _pages.BindingShapes(_currentPageIndex);
            }
        }

        // for IState 做 Undo Redo
        public CommandManager CommandManager
        {
            get
            {
                return _commandManager;
            }
        }

        // GetCurrentPageIndex
        public int GetCurrentPageIndex()
        {
            return _currentPageIndex;
        }

        // 取得頁面數量
        public int GetNumPages()
        {
            return _pages.GetNumPages();
        }

        // 取得頁面for delete command
        public Shapes GetPage(int pageIndex)
        {
            return _pages.GetPage(pageIndex);
        }

        // 增加頁面
        public void AddPage(int index)
        {
            _pages.AddPage(index);
            _currentPageIndex = index;
            NotifyModelChanged();
        }

        // 增加頁面 by Shapes for delete command
        public void AddPage(int index, Shapes shapes)
        {
            _pages.AddPage(index, shapes);
            _currentPageIndex = index;
            NotifyModelChanged();
        }

        // 增加頁面
        public void AddPageToCommandManager()
        {
            _commandManager.Execute(new AddPageCommand(this, _currentPageIndex + 1));
        }

        // 切換頁面
        public void SwitchPage(int index)
        {
            _currentPageIndex = index;
            NotifyModelChanged();
        }

        // 刪除頁面
        public void DeletePage(int index)
        {
            if (_pages.GetNumPages() == 1)
                _pages.ClearShapes(0);
            else
            {
                _pages.DeletePage(index);
                _currentPageIndex = (_currentPageIndex - 1) >= 0 ? _currentPageIndex - 1 : 0;
            }
        }

        // 刪除頁面
        public void DeletePageToCommandManager()
        {
            _commandManager.Execute(new DeletePageCommand(this, _currentPageIndex));
        }

        // 新增隨機形狀到 CmdManager
        public void AddShapeToCommandManager(string shapeName, int x1, int y1, int x2, int y2)
        {
            _commandManager.Execute(new AddCommand(this, _currentPageIndex, shapeName, 
                x1, y1, x2, y2));
        }

        // 新增形狀 回傳形狀index
        public int AddShape(int pageIndex, string shapeName, int x1, int y1, int x2, int y2)
        {
            int index = _pages.AddShape(pageIndex, shapeName, x1, y1, x2, y2);
            NotifyModelChanged();
            return index;
        }

        // 新增形狀 回傳形狀index
        public int AddShape(int pageIndex, Shape shape)
        {
            int index = _pages.AddShape(pageIndex, shape);
            NotifyModelChanged();
            return index;
        }

        // 刪除形狀
        public void DeleteShape(int pageIndex, int index)
        {
            _pages.DeleteShape(pageIndex, index);
            NotifyModelChanged();
        }

        // 刪除形狀
        public void DeleteShapeToCommandManager(int index)
        {
            _commandManager.Execute(new DeleteCommand(this, _currentPageIndex, index));
        }

        // ChangeState
        public void ChangeState(string shapeType)
        {
            if (shapeType == POINTER)
            {
                _state = _pointState;
            }
            else if (shapeType == LINE)
            {
                _state = _lineState;
            }
            else if (shapeType == RECTANGLE)
            {
                _state = _rectangleState;
            }
            else if (shapeType == CIRCLE)
            {
                _state = _circleState;
            }
        }

        // 取得工具列狀態
        public string GetToolState()
        {
            return _state.GetStateName();
        }

        // IsUndoEnabled
        public bool IsUndoEnabled()
        {
            return _commandManager.IsUndoEnabled();
        }

        // IsRedoEnabled
        public bool IsRedoEnabled()
        {
            return _commandManager.IsRedoEnabled();
        }

        // Undo
        public void Undo()
        {
            _commandManager.Undo();
        }

        // Redo
        public void Redo()
        {
            _commandManager.Redo();
        }

        // 選取並回傳指標所選取最上面的形狀的index
        // 無選到任何形狀回傳-1
        public int SelectShape(int pointX, int pointY)
        {
            return _pages.SelectShape(_currentPageIndex, pointX, pointY);
        }

        // 取得形狀
        public Shape GetShape(int pageIndex, int index)
        {
            return _pages.GetShape(pageIndex, index);
        }

        // 插入形狀
        public void InsertShape(int pageIndex, int index, Shape shape)
        {
            _pages.InsertShape(pageIndex, index, shape);
            NotifyModelChanged();
        }

        // 移動形狀by位移
        public void MoveShape(int index, int offsetX, int offsetY)
        {
            _pages.MoveShape(_currentPageIndex, index, offsetX, offsetY);
        }

        // KeyDown
        public void KeyDown(string key)
        {
            _state.KeyDown(key);
        }

        // 在畫布中按下左鍵
        public void CanvasPressed(int pointX, int pointY)
        {
            _state.MouseDown(pointX, pointY);
        }

        // 在畫布中移動
        public void CanvasMoved(int pointX, int pointY)
        {
            _state.MouseMove(pointX, pointY);
            NotifyModelChanged();
        }

        // 在畫布中放開左鍵
        public void CanvasReleased(int pointX, int pointY)
        {
            _state.MouseUp(pointX, pointY);
            _state = _pointState;
            NotifyModelChanged();
        }
        
        // 畫布繪圖(當前頁面)
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();
            _pages.DrawShapes(_currentPageIndex, graphics);
            _state.Draw(graphics);
        }

        // 畫布繪圖(By index)
        public void Draw(int pageIndex, IGraphics graphics)
        {
            graphics.ClearAll();
            _pages.DrawShapes(pageIndex, graphics);
        }

        // Save
        public bool Save()
        {
            try
            {
                string path = "PPT.fppt";
                StreamWriter streamWriter = new StreamWriter(path, false, Encoding.UTF8);
                _pages.SaveShapes(streamWriter);
                streamWriter.Close();
                const string CONTENT_TYPE = "application/octet-stream";
                string fileId = SearchCloudFile(path);
                if (fileId == "")
                    _service.UploadFile(path, CONTENT_TYPE);
                else
                    _service.UpdateFile(path, fileId, CONTENT_TYPE);
                Thread.Sleep(10000);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Load
        public bool Load()
        {
            try
            {
                string path = System.Windows.Forms.Application.StartupPath;
                string title = "PPT.fppt";
                List<Google.Apis.Drive.v2.Data.File> rootFoldersFiles = _service.ListRootFileAndFolder();
                Google.Apis.Drive.v2.Data.File foundFile = rootFoldersFiles.Find(item => item.Title == title);
                _service.DownloadFile(foundFile, path);
                StreamReader streamReader = new StreamReader(title);
                _pages.LoadPages(streamReader);
                streamReader.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 尋找雲端檔案
        private string SearchCloudFile(string fileName)
        {
            List<Google.Apis.Drive.v2.Data.File> fileList = _service.ListRootFileAndFolder();
            Google.Apis.Drive.v2.Data.File foundFile = fileList.Find(item => { return item.Title == fileName; });
            if (foundFile != null)
                return foundFile.Id;
            else
                return "";
        }

        // Model改變事件
        private void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
