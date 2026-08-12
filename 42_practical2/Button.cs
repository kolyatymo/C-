using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_practical2
{
    public interface Button
    {
        void render();
        void onClick();
    }

    public class Windows : Button
    {
        public void onClick()
        {
            Console.WriteLine("Windows a Click");
        }

        public void render()
        {
            Console.WriteLine("Windows Render");
        }
    }

    public class HTML : Button
    {
        public void onClick()
        {
            Console.WriteLine("HTML a Click");
        }

        public void render()
        {
            Console.WriteLine("HTML Render");
        }
    }

    abstract public class Dialog
    {
        abstract public Button createButton();
        public void render()
        {
            Button button = createButton();
            button.render();
            button.onClick();

        }

    }

    public class WindowsDialog : Dialog
    {
        public override Button createButton()
        {
            return new Windows();
        }
    }
    public class WebDialog : Dialog
    {
        public override Button createButton()
        {
            return new HTML();
        }
    }
}

