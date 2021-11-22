using System;

namespace LW2
{
    class Program
    {
        static void Main()
        {
            BTree btree = new BTree();
            btree.InsertNode("0", 0, "test", "testname", 1979, 5);
            btree.InsertNode("1", 1, "test1", "testname", 1981, 5);
            btree.InsertNode("2", 2, "test2", "testname", 1990, 5);
            btree.InsertNode("3", 3, "test3", "testname", 2000, 5);
            btree.InsertNode("4", 4, "test4", "testname", 1964, 5);
	        btree.InsertNode("5", 5, "test4", "testname", 1845, 5);
	        btree.InsertNode("6", 6, "test4", "testname", 2005, 5);
	        btree.InsertNode("7", 7, "test4", "testname", 1700, 5);
	        btree.InsertNode("8", 8, "test4", "testname", 1710, 5);
	        btree.InsertNode("9", 9, "test4", "testname", 1600, 5);
            btree.PrintTree();

            btree.DeleteNode("2");
            btree.DeleteNode("3");
            btree.PrintTree();
        }
    }
}
