namespace Kanban
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            this.InProListView = new System.Windows.Forms.DataGridView();
            this.DoneListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtnToDo = new System.Windows.Forms.Button();
            this.saveBtnInPro = new System.Windows.Forms.Button();
            this.saveBtnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToDoEditBtn = new System.Windows.Forms.Button();
            this.InProEditBtn = new System.Windows.Forms.Button();
            this.DoneEditBtn = new System.Windows.Forms.Button();
            this.textBoxToDo = new System.Windows.Forms.TextBox();
            this.textBoxInPro = new System.Windows.Forms.TextBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.MoveInProBtn = new System.Windows.Forms.Button();
            this.MoveDoneBtn = new System.Windows.Forms.Button();
            this.DelToDoBtn = new System.Windows.Forms.Button();
            this.DelInProBtn = new System.Windows.Forms.Button();
            this.DelDoneBtn = new System.Windows.Forms.Button();
            this.ToDoTasklbl = new System.Windows.Forms.Label();
            this.inProlbl = new System.Windows.Forms.Label();
            this.Donelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InProListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDoListView
            // 
            this.ToDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(12, 165);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.Size = new System.Drawing.Size(249, 481);
            this.ToDoListView.TabIndex = 16;
            // 
            // InProListView
            // 
            this.InProListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InProListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InProListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InProListView.Location = new System.Drawing.Point(286, 165);
            this.InProListView.Name = "InProListView";
            this.InProListView.Size = new System.Drawing.Size(249, 481);
            this.InProListView.TabIndex = 19;
            // 
            // DoneListView
            // 
            this.DoneListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoneListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DoneListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoneListView.Location = new System.Drawing.Point(555, 165);
            this.DoneListView.Name = "DoneListView";
            this.DoneListView.Size = new System.Drawing.Size(249, 481);
            this.DoneListView.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kanban App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveBtnToDo
            // 
            this.saveBtnToDo.Location = new System.Drawing.Point(12, 652);
            this.saveBtnToDo.Name = "saveBtnToDo";
            this.saveBtnToDo.Size = new System.Drawing.Size(117, 23);
            this.saveBtnToDo.TabIndex = 22;
            this.saveBtnToDo.Text = "Save";
            this.saveBtnToDo.UseVisualStyleBackColor = true;
            this.saveBtnToDo.Click += new System.EventHandler(this.saveBtnToDo_Click);
            // 
            // saveBtnInPro
            // 
            this.saveBtnInPro.Location = new System.Drawing.Point(286, 652);
            this.saveBtnInPro.Name = "saveBtnInPro";
            this.saveBtnInPro.Size = new System.Drawing.Size(123, 23);
            this.saveBtnInPro.TabIndex = 23;
            this.saveBtnInPro.Text = "Save";
            this.saveBtnInPro.UseVisualStyleBackColor = true;
            this.saveBtnInPro.Click += new System.EventHandler(this.saveBtnInPro_Click);
            // 
            // saveBtnDone
            // 
            this.saveBtnDone.Location = new System.Drawing.Point(555, 652);
            this.saveBtnDone.Name = "saveBtnDone";
            this.saveBtnDone.Size = new System.Drawing.Size(117, 23);
            this.saveBtnDone.TabIndex = 24;
            this.saveBtnDone.Text = "Save";
            this.saveBtnDone.UseVisualStyleBackColor = true;
            this.saveBtnDone.Click += new System.EventHandler(this.saveBtnDone_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "To Do";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "In Progress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(637, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Done";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDoEditBtn
            // 
            this.ToDoEditBtn.Location = new System.Drawing.Point(145, 652);
            this.ToDoEditBtn.Name = "ToDoEditBtn";
            this.ToDoEditBtn.Size = new System.Drawing.Size(116, 23);
            this.ToDoEditBtn.TabIndex = 28;
            this.ToDoEditBtn.Text = "Edit";
            this.ToDoEditBtn.UseVisualStyleBackColor = true;
            this.ToDoEditBtn.Click += new System.EventHandler(this.ToDoEditBtn_Click);
            // 
            // InProEditBtn
            // 
            this.InProEditBtn.Location = new System.Drawing.Point(419, 652);
            this.InProEditBtn.Name = "InProEditBtn";
            this.InProEditBtn.Size = new System.Drawing.Size(116, 23);
            this.InProEditBtn.TabIndex = 29;
            this.InProEditBtn.Text = "Edit";
            this.InProEditBtn.UseVisualStyleBackColor = true;
            this.InProEditBtn.Click += new System.EventHandler(this.InProEditBtn_Click);
            // 
            // DoneEditBtn
            // 
            this.DoneEditBtn.Location = new System.Drawing.Point(687, 652);
            this.DoneEditBtn.Name = "DoneEditBtn";
            this.DoneEditBtn.Size = new System.Drawing.Size(116, 23);
            this.DoneEditBtn.TabIndex = 30;
            this.DoneEditBtn.Text = "Edit";
            this.DoneEditBtn.UseVisualStyleBackColor = true;
            this.DoneEditBtn.Click += new System.EventHandler(this.DoneEditBtn_Click);
            // 
            // textBoxToDo
            // 
            this.textBoxToDo.BackColor = System.Drawing.Color.White;
            this.textBoxToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToDo.ForeColor = System.Drawing.Color.Black;
            this.textBoxToDo.Location = new System.Drawing.Point(12, 107);
            this.textBoxToDo.Name = "textBoxToDo";
            this.textBoxToDo.Size = new System.Drawing.Size(249, 26);
            this.textBoxToDo.TabIndex = 31;
            // 
            // textBoxInPro
            // 
            this.textBoxInPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInPro.Location = new System.Drawing.Point(286, 107);
            this.textBoxInPro.Name = "textBoxInPro";
            this.textBoxInPro.Size = new System.Drawing.Size(249, 26);
            this.textBoxInPro.TabIndex = 32;
            // 
            // textBoxDone
            // 
            this.textBoxDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDone.Location = new System.Drawing.Point(555, 107);
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.Size = new System.Drawing.Size(249, 26);
            this.textBoxDone.TabIndex = 33;
            // 
            // MoveInProBtn
            // 
            this.MoveInProBtn.Location = new System.Drawing.Point(12, 681);
            this.MoveInProBtn.Name = "MoveInProBtn";
            this.MoveInProBtn.Size = new System.Drawing.Size(117, 23);
            this.MoveInProBtn.TabIndex = 34;
            this.MoveInProBtn.Text = "Move to in progress";
            this.MoveInProBtn.UseVisualStyleBackColor = true;
            this.MoveInProBtn.Click += new System.EventHandler(this.MoveInProBtn_Click);
            // 
            // MoveDoneBtn
            // 
            this.MoveDoneBtn.Location = new System.Drawing.Point(286, 681);
            this.MoveDoneBtn.Name = "MoveDoneBtn";
            this.MoveDoneBtn.Size = new System.Drawing.Size(123, 23);
            this.MoveDoneBtn.TabIndex = 35;
            this.MoveDoneBtn.Text = "Move to done";
            this.MoveDoneBtn.UseVisualStyleBackColor = true;
            this.MoveDoneBtn.Click += new System.EventHandler(this.MoveDoneBtn_Click);
            // 
            // DelToDoBtn
            // 
            this.DelToDoBtn.Location = new System.Drawing.Point(145, 681);
            this.DelToDoBtn.Name = "DelToDoBtn";
            this.DelToDoBtn.Size = new System.Drawing.Size(116, 23);
            this.DelToDoBtn.TabIndex = 36;
            this.DelToDoBtn.Text = "Delete";
            this.DelToDoBtn.UseVisualStyleBackColor = true;
            this.DelToDoBtn.Click += new System.EventHandler(this.DelToDoBtn_Click);
            // 
            // DelInProBtn
            // 
            this.DelInProBtn.Location = new System.Drawing.Point(419, 681);
            this.DelInProBtn.Name = "DelInProBtn";
            this.DelInProBtn.Size = new System.Drawing.Size(116, 23);
            this.DelInProBtn.TabIndex = 37;
            this.DelInProBtn.Text = "Delete";
            this.DelInProBtn.UseVisualStyleBackColor = true;
            this.DelInProBtn.Click += new System.EventHandler(this.DelInProBtn_Click);
            // 
            // DelDoneBtn
            // 
            this.DelDoneBtn.Location = new System.Drawing.Point(687, 681);
            this.DelDoneBtn.Name = "DelDoneBtn";
            this.DelDoneBtn.Size = new System.Drawing.Size(116, 23);
            this.DelDoneBtn.TabIndex = 38;
            this.DelDoneBtn.Text = "Delete";
            this.DelDoneBtn.UseVisualStyleBackColor = true;
            this.DelDoneBtn.Click += new System.EventHandler(this.DelDoneBtn_Click);
            // 
            // ToDoTasklbl
            // 
            this.ToDoTasklbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToDoTasklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoTasklbl.Location = new System.Drawing.Point(12, 81);
            this.ToDoTasklbl.Name = "ToDoTasklbl";
            this.ToDoTasklbl.Size = new System.Drawing.Size(249, 23);
            this.ToDoTasklbl.TabIndex = 39;
            this.ToDoTasklbl.Text = "To Do Tasks";
            this.ToDoTasklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inProlbl
            // 
            this.inProlbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inProlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProlbl.Location = new System.Drawing.Point(286, 81);
            this.inProlbl.Name = "inProlbl";
            this.inProlbl.Size = new System.Drawing.Size(249, 23);
            this.inProlbl.TabIndex = 40;
            this.inProlbl.Text = "In Progress Tasks";
            this.inProlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Donelbl
            // 
            this.Donelbl.BackColor = System.Drawing.SystemColors.Info;
            this.Donelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donelbl.Location = new System.Drawing.Point(554, 81);
            this.Donelbl.Name = "Donelbl";
            this.Donelbl.Size = new System.Drawing.Size(249, 23);
            this.Donelbl.TabIndex = 41;
            this.Donelbl.Text = "Done Tasks";
            this.Donelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 721);
            this.Controls.Add(this.Donelbl);
            this.Controls.Add(this.inProlbl);
            this.Controls.Add(this.ToDoTasklbl);
            this.Controls.Add(this.DelDoneBtn);
            this.Controls.Add(this.DelInProBtn);
            this.Controls.Add(this.DelToDoBtn);
            this.Controls.Add(this.MoveDoneBtn);
            this.Controls.Add(this.MoveInProBtn);
            this.Controls.Add(this.textBoxDone);
            this.Controls.Add(this.textBoxInPro);
            this.Controls.Add(this.textBoxToDo);
            this.Controls.Add(this.DoneEditBtn);
            this.Controls.Add(this.InProEditBtn);
            this.Controls.Add(this.ToDoEditBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtnDone);
            this.Controls.Add(this.saveBtnInPro);
            this.Controls.Add(this.saveBtnToDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoneListView);
            this.Controls.Add(this.InProListView);
            this.Controls.Add(this.ToDoListView);
            this.Name = "MainForm";
            this.Text = "Kanban App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InProListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ToDoListView;
        private System.Windows.Forms.DataGridView InProListView;
        private System.Windows.Forms.DataGridView DoneListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtnToDo;
        private System.Windows.Forms.Button saveBtnInPro;
        private System.Windows.Forms.Button saveBtnDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ToDoEditBtn;
        private System.Windows.Forms.Button InProEditBtn;
        private System.Windows.Forms.Button DoneEditBtn;
        private System.Windows.Forms.TextBox textBoxToDo;
        private System.Windows.Forms.TextBox textBoxInPro;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.Button MoveInProBtn;
        private System.Windows.Forms.Button MoveDoneBtn;
        private System.Windows.Forms.Button DelToDoBtn;
        private System.Windows.Forms.Button DelInProBtn;
        private System.Windows.Forms.Button DelDoneBtn;
        private System.Windows.Forms.Label ToDoTasklbl;
        private System.Windows.Forms.Label inProlbl;
        private System.Windows.Forms.Label Donelbl;
    }
}

