using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas_tree_decorator
{
    internal class Run
    {
        public void run()
        {
            //Console.CursorVisible = false;
            int[] position= {0,0};
            int[] oldposition = position;
            Tree tree = new Tree();
            Cursor cursor = new Cursor();
            int treebig = 0;
            bool geenint = true;
            string decoration = " ";
            string[,] christmastree = tree.treeplatform();
            ConsoleKeyInfo keypress = new ConsoleKeyInfo();


            Console.WriteLine("hoegroot tree?max 25");
            while (geenint == true)
            {
                try
                {
                    treebig = Convert.ToInt32(Console.ReadLine());
                    if (treebig < 26)
                    {
                        geenint = false;
                    }
                }
                catch{}
            }
            Console.WriteLine("waarmee decoreren?");
            decoration = Console.ReadLine();
            if (decoration == null)
            {
                decoration = "o";
            }
            tree.generatetree(treebig, christmastree);
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                keypress = Console.ReadKey();
                try
                {
                    string old_block = tree.getoldblock(position, christmastree);
                    tree.setoldblock(christmastree, position, old_block);
                    position = cursor.move(keypress, position);
                    cursor.setcursor(position, "o");
                    tree.decorate(christmastree, position, decoration, keypress);

                }
                catch
                {
                    Console.WriteLine("oeps, out of bounds");
                }
            }
        }
    }
}
