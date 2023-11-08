using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KanbanBackend;

namespace Kanban
{
    public partial class MainForm : Form
    {
        KanbanManager taskList = new KanbanManager();
        
        public MainForm()
        {
            InitializeComponent();
            ToDoListView.DataSource = taskList.kanbanToDo;
            InProListView.DataSource = taskList.kanbanInPro;
            DoneListView.DataSource = taskList.kanbanDone;
        }

        bool isEditing = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }

        private void ToDoEditBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            textBoxToDo.Text = taskList.kanbanToDo.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
        }

        private void InProEditBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            textBoxInPro.Text = taskList.kanbanInPro.Rows[InProListView.CurrentCell.RowIndex].ItemArray[0].ToString();
        }

        private void DoneEditBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            textBoxDone.Text = taskList.kanbanDone.Rows[DoneListView.CurrentCell.RowIndex].ItemArray[0].ToString();
        }

        private void DelToDoBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in ToDoListView.SelectedCells)
            {
                int rowIndex = cell.RowIndex;
                taskList.kanbanToDo.Rows.RemoveAt(rowIndex);
            }
        }

        private void DelInProBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in InProListView.SelectedCells)
            {
                int rowIndex = cell.RowIndex;
                taskList.kanbanInPro.Rows.RemoveAt(rowIndex);
            }
        }

        private void DelDoneBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in DoneListView.SelectedCells)
            {
                int rowIndex = cell.RowIndex;
                taskList.kanbanDone.Rows.RemoveAt(rowIndex);
            }
        }

        private void saveBtnToDo_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                taskList.kanbanToDo.Rows[ToDoListView.CurrentCell.RowIndex]["To do"] = textBoxToDo.Text;
            }
            else
            {
                taskList.kanbanToDo.Rows.Add(textBoxToDo.Text);
            }
            textBoxToDo.Text = "";
            isEditing = false;
        }

        private void saveBtnInPro_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                taskList.kanbanInPro.Rows[InProListView.CurrentCell.RowIndex]["In Progress"] = textBoxInPro.Text;
            }
            else
            {
                taskList.kanbanInPro.Rows.Add(textBoxInPro.Text);
            }
            textBoxInPro.Text = "";
            isEditing = false;
        }

        private void saveBtnDone_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                taskList.kanbanDone.Rows[DoneListView.CurrentCell.RowIndex]["Done"] = textBoxDone.Text;
            }
            else
            {
                taskList.kanbanDone.Rows.Add(textBoxDone.Text);
            }
            textBoxDone.Text = "";
            isEditing = false;
        }

        private void MoveInProBtn_Click(object sender, EventArgs e)
        {
            if (ToDoListView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = ToDoListView.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    string task = taskList.kanbanToDo.Rows[selectedRowIndex]["To do"].ToString();

                    //Mueve la tarea de To do a In Progress
                    taskList.kanbanInPro.Rows.Add(task);

                    //Elimina la tarea de To Do
                    taskList.kanbanToDo.Rows.RemoveAt(selectedRowIndex);
                }
            }
        }

        private void MoveDoneBtn_Click(object sender, EventArgs e)
        {
            if (InProListView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = InProListView.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    string task = taskList.kanbanInPro.Rows[selectedRowIndex]["In Progress"].ToString();

                    //Mueve la tarea de In Progress a Done
                    taskList.kanbanDone.Rows.Add(task);

                    //Elimina la tarea de In Progress
                    taskList.kanbanInPro.Rows.RemoveAt(selectedRowIndex);
                }
            }
        }
    }
}
