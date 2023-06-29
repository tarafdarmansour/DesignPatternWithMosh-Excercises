using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Main
    {
        public static void main(MyEditor myEditor)
        {
            myEditor.SetContent("a");
            myEditor.SetContent("b");
            myEditor.SetContent("c");
            myEditor.Undo();
        }
    }
}
