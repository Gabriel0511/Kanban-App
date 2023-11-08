using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBackend
{
    public class KanbanManager
    {
        public DataTable kanbanToDo = new DataTable();
        public DataTable kanbanInPro = new DataTable();
        public DataTable kanbanDone = new DataTable();

        public KanbanManager()
        {
            kanbanToDo.Columns.Add("To do");
            kanbanInPro.Columns.Add("In Progress");
            kanbanDone.Columns.Add("Done");
        }


    }
}
