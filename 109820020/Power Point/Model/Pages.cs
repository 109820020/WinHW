using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Power_Point
{
    public class Pages
    {
        private List<Shapes> _pages;

        public Pages()
        {
            _pages = new List<Shapes>();
        }

        // 增加頁面
        public void AddPage()
        {
            _pages.Add(new Shapes());
        }
    }
}
