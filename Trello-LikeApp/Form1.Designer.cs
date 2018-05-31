namespace Trello_LikeApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbCntrl = new System.Windows.Forms.TabControl();
            this.AddJbTB = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.EndTimeDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StartTimeDate = new System.Windows.Forms.DateTimePicker();
            this.save_button = new System.Windows.Forms.Button();
            this.ShortDescTextBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectManagerTextBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectNameTextBx = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TaskPriority = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxSTDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubTasks = new System.Windows.Forms.Button();
            this.lblProjects = new System.Windows.Forms.Label();
            this.lstBxProjects = new System.Windows.Forms.CheckedListBox();
            this.bxEmployeers = new System.Windows.Forms.ComboBox();
            this.txtSTDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SbTaskName = new System.Windows.Forms.Label();
            this.txtSTName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadPrEditor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.editProjectsChckBox = new System.Windows.Forms.CheckedListBox();
            this.DeadLinesTab = new System.Windows.Forms.TabPage();
            this.ProjectsNearDeadLinelstbx = new System.Windows.Forms.ListBox();
            this.projectListLbl = new System.Windows.Forms.Label();
            this.DeadLinesCalendar = new System.Windows.Forms.MonthCalendar();
            this.Employee = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegisterEmployee = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dniTxtBx = new System.Windows.Forms.TextBox();
            this.ageTxtBx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBoxEmployees = new System.Windows.Forms.ListBox();
            this.SaveEmployeeButton = new System.Windows.Forms.Button();
            this.TxtBxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.TxtBxEmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeSurname = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.languageCmbBx = new System.Windows.Forms.ComboBox();
            this.TbCntrl.SuspendLayout();
            this.AddJbTB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPriority)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.DeadLinesTab.SuspendLayout();
            this.Employee.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegisterEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCntrl
            // 
            resources.ApplyResources(this.TbCntrl, "TbCntrl");
            this.TbCntrl.Controls.Add(this.AddJbTB);
            this.TbCntrl.Controls.Add(this.DeadLinesTab);
            this.TbCntrl.Controls.Add(this.Employee);
            this.TbCntrl.Name = "TbCntrl";
            this.TbCntrl.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.TbCntrl, resources.GetString("TbCntrl.ToolTip"));
            // 
            // AddJbTB
            // 
            resources.ApplyResources(this.AddJbTB, "AddJbTB");
            this.AddJbTB.Controls.Add(this.tabControl1);
            this.AddJbTB.Name = "AddJbTB";
            this.toolTip1.SetToolTip(this.AddJbTB, resources.GetString("AddJbTB.ToolTip"));
            this.AddJbTB.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            this.tabControl1.Enter += new System.EventHandler(this.ProjectsLoad);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.EndTimeDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.StartTimeDate);
            this.tabPage1.Controls.Add(this.save_button);
            this.tabPage1.Controls.Add(this.ShortDescTextBx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ProjectManagerTextBx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ProjectNameTextBx);
            this.tabPage1.Name = "tabPage1";
            this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // EndTimeDate
            // 
            resources.ApplyResources(this.EndTimeDate, "EndTimeDate");
            this.EndTimeDate.Name = "EndTimeDate";
            this.toolTip1.SetToolTip(this.EndTimeDate, resources.GetString("EndTimeDate.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // StartTimeDate
            // 
            resources.ApplyResources(this.StartTimeDate, "StartTimeDate");
            this.StartTimeDate.Name = "StartTimeDate";
            this.toolTip1.SetToolTip(this.StartTimeDate, resources.GetString("StartTimeDate.ToolTip"));
            // 
            // save_button
            // 
            resources.ApplyResources(this.save_button, "save_button");
            this.save_button.Name = "save_button";
            this.toolTip1.SetToolTip(this.save_button, resources.GetString("save_button.ToolTip"));
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // ShortDescTextBx
            // 
            resources.ApplyResources(this.ShortDescTextBx, "ShortDescTextBx");
            this.ShortDescTextBx.Name = "ShortDescTextBx";
            this.toolTip1.SetToolTip(this.ShortDescTextBx, resources.GetString("ShortDescTextBx.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // ProjectManagerTextBx
            // 
            resources.ApplyResources(this.ProjectManagerTextBx, "ProjectManagerTextBx");
            this.ProjectManagerTextBx.Name = "ProjectManagerTextBx";
            this.toolTip1.SetToolTip(this.ProjectManagerTextBx, resources.GetString("ProjectManagerTextBx.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // ProjectNameTextBx
            // 
            resources.ApplyResources(this.ProjectNameTextBx, "ProjectNameTextBx");
            this.ProjectNameTextBx.Name = "ProjectNameTextBx";
            this.toolTip1.SetToolTip(this.ProjectNameTextBx, resources.GetString("ProjectNameTextBx.ToolTip"));
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Controls.Add(this.TaskPriority);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtBxSTDuration);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.btnSubTasks);
            this.tabPage4.Controls.Add(this.lblProjects);
            this.tabPage4.Controls.Add(this.lstBxProjects);
            this.tabPage4.Controls.Add(this.bxEmployeers);
            this.tabPage4.Controls.Add(this.txtSTDescription);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.SbTaskName);
            this.tabPage4.Controls.Add(this.txtSTName);
            this.tabPage4.Name = "tabPage4";
            this.toolTip1.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TaskPriority
            // 
            resources.ApplyResources(this.TaskPriority, "TaskPriority");
            this.TaskPriority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TaskPriority.Name = "TaskPriority";
            this.toolTip1.SetToolTip(this.TaskPriority, resources.GetString("TaskPriority.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // txtBxSTDuration
            // 
            resources.ApplyResources(this.txtBxSTDuration, "txtBxSTDuration");
            this.txtBxSTDuration.Name = "txtBxSTDuration";
            this.toolTip1.SetToolTip(this.txtBxSTDuration, resources.GetString("txtBxSTDuration.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // btnSubTasks
            // 
            resources.ApplyResources(this.btnSubTasks, "btnSubTasks");
            this.btnSubTasks.Name = "btnSubTasks";
            this.toolTip1.SetToolTip(this.btnSubTasks, resources.GetString("btnSubTasks.ToolTip"));
            this.btnSubTasks.UseVisualStyleBackColor = true;
            this.btnSubTasks.Click += new System.EventHandler(this.SaveSubTasks);
            // 
            // lblProjects
            // 
            resources.ApplyResources(this.lblProjects, "lblProjects");
            this.lblProjects.Name = "lblProjects";
            this.toolTip1.SetToolTip(this.lblProjects, resources.GetString("lblProjects.ToolTip"));
            // 
            // lstBxProjects
            // 
            resources.ApplyResources(this.lstBxProjects, "lstBxProjects");
            this.lstBxProjects.FormattingEnabled = true;
            this.lstBxProjects.Name = "lstBxProjects";
            this.toolTip1.SetToolTip(this.lstBxProjects, resources.GetString("lstBxProjects.ToolTip"));
            this.lstBxProjects.SelectedIndexChanged += new System.EventHandler(this.lstBxProjects_SelectedIndexChanged);
            // 
            // bxEmployeers
            // 
            resources.ApplyResources(this.bxEmployeers, "bxEmployeers");
            this.bxEmployeers.FormattingEnabled = true;
            this.bxEmployeers.Name = "bxEmployeers";
            this.toolTip1.SetToolTip(this.bxEmployeers, resources.GetString("bxEmployeers.ToolTip"));
            // 
            // txtSTDescription
            // 
            resources.ApplyResources(this.txtSTDescription, "txtSTDescription");
            this.txtSTDescription.Name = "txtSTDescription";
            this.toolTip1.SetToolTip(this.txtSTDescription, resources.GetString("txtSTDescription.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // SbTaskName
            // 
            resources.ApplyResources(this.SbTaskName, "SbTaskName");
            this.SbTaskName.Name = "SbTaskName";
            this.toolTip1.SetToolTip(this.SbTaskName, resources.GetString("SbTaskName.ToolTip"));
            // 
            // txtSTName
            // 
            resources.ApplyResources(this.txtSTName, "txtSTName");
            this.txtSTName.Name = "txtSTName";
            this.toolTip1.SetToolTip(this.txtSTName, resources.GetString("txtSTName.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.loadPrEditor);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.editProjectsChckBox);
            this.tabPage2.Name = "tabPage2";
            this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadPrEditor
            // 
            resources.ApplyResources(this.loadPrEditor, "loadPrEditor");
            this.loadPrEditor.Name = "loadPrEditor";
            this.toolTip1.SetToolTip(this.loadPrEditor, resources.GetString("loadPrEditor.ToolTip"));
            this.loadPrEditor.UseVisualStyleBackColor = true;
            this.loadPrEditor.Click += new System.EventHandler(this.loadPrEdit);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // editProjectsChckBox
            // 
            resources.ApplyResources(this.editProjectsChckBox, "editProjectsChckBox");
            this.editProjectsChckBox.FormattingEnabled = true;
            this.editProjectsChckBox.Name = "editProjectsChckBox";
            this.toolTip1.SetToolTip(this.editProjectsChckBox, resources.GetString("editProjectsChckBox.ToolTip"));
            // 
            // DeadLinesTab
            // 
            resources.ApplyResources(this.DeadLinesTab, "DeadLinesTab");
            this.DeadLinesTab.Controls.Add(this.ProjectsNearDeadLinelstbx);
            this.DeadLinesTab.Controls.Add(this.projectListLbl);
            this.DeadLinesTab.Controls.Add(this.DeadLinesCalendar);
            this.DeadLinesTab.Name = "DeadLinesTab";
            this.toolTip1.SetToolTip(this.DeadLinesTab, resources.GetString("DeadLinesTab.ToolTip"));
            this.DeadLinesTab.UseVisualStyleBackColor = true;
            // 
            // ProjectsNearDeadLinelstbx
            // 
            resources.ApplyResources(this.ProjectsNearDeadLinelstbx, "ProjectsNearDeadLinelstbx");
            this.ProjectsNearDeadLinelstbx.FormattingEnabled = true;
            this.ProjectsNearDeadLinelstbx.Name = "ProjectsNearDeadLinelstbx";
            this.toolTip1.SetToolTip(this.ProjectsNearDeadLinelstbx, resources.GetString("ProjectsNearDeadLinelstbx.ToolTip"));
            // 
            // projectListLbl
            // 
            resources.ApplyResources(this.projectListLbl, "projectListLbl");
            this.projectListLbl.Name = "projectListLbl";
            this.toolTip1.SetToolTip(this.projectListLbl, resources.GetString("projectListLbl.ToolTip"));
            // 
            // DeadLinesCalendar
            // 
            resources.ApplyResources(this.DeadLinesCalendar, "DeadLinesCalendar");
            this.DeadLinesCalendar.Name = "DeadLinesCalendar";
            this.toolTip1.SetToolTip(this.DeadLinesCalendar, resources.GetString("DeadLinesCalendar.ToolTip"));
            // 
            // Employee
            // 
            resources.ApplyResources(this.Employee, "Employee");
            this.Employee.Controls.Add(this.tabControl2);
            this.Employee.Name = "Employee";
            this.toolTip1.SetToolTip(this.Employee, resources.GetString("Employee.ToolTip"));
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tabRegisterEmployee);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl2, resources.GetString("tabControl2.ToolTip"));
            // 
            // tabRegisterEmployee
            // 
            resources.ApplyResources(this.tabRegisterEmployee, "tabRegisterEmployee");
            this.tabRegisterEmployee.Controls.Add(this.label13);
            this.tabRegisterEmployee.Controls.Add(this.dniTxtBx);
            this.tabRegisterEmployee.Controls.Add(this.ageTxtBx);
            this.tabRegisterEmployee.Controls.Add(this.label12);
            this.tabRegisterEmployee.Controls.Add(this.label8);
            this.tabRegisterEmployee.Controls.Add(this.lstBoxEmployees);
            this.tabRegisterEmployee.Controls.Add(this.SaveEmployeeButton);
            this.tabRegisterEmployee.Controls.Add(this.TxtBxEmployeeSurname);
            this.tabRegisterEmployee.Controls.Add(this.TxtBxEmployeeName);
            this.tabRegisterEmployee.Controls.Add(this.EmployeeSurname);
            this.tabRegisterEmployee.Controls.Add(this.EmployeeName);
            this.tabRegisterEmployee.Name = "tabRegisterEmployee";
            this.toolTip1.SetToolTip(this.tabRegisterEmployee, resources.GetString("tabRegisterEmployee.ToolTip"));
            this.tabRegisterEmployee.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // dniTxtBx
            // 
            resources.ApplyResources(this.dniTxtBx, "dniTxtBx");
            this.dniTxtBx.Name = "dniTxtBx";
            this.toolTip1.SetToolTip(this.dniTxtBx, resources.GetString("dniTxtBx.ToolTip"));
            // 
            // ageTxtBx
            // 
            resources.ApplyResources(this.ageTxtBx, "ageTxtBx");
            this.ageTxtBx.Name = "ageTxtBx";
            this.toolTip1.SetToolTip(this.ageTxtBx, resources.GetString("ageTxtBx.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // lstBoxEmployees
            // 
            resources.ApplyResources(this.lstBoxEmployees, "lstBoxEmployees");
            this.lstBoxEmployees.FormattingEnabled = true;
            this.lstBoxEmployees.Name = "lstBoxEmployees";
            this.toolTip1.SetToolTip(this.lstBoxEmployees, resources.GetString("lstBoxEmployees.ToolTip"));
            // 
            // SaveEmployeeButton
            // 
            resources.ApplyResources(this.SaveEmployeeButton, "SaveEmployeeButton");
            this.SaveEmployeeButton.Name = "SaveEmployeeButton";
            this.toolTip1.SetToolTip(this.SaveEmployeeButton, resources.GetString("SaveEmployeeButton.ToolTip"));
            this.SaveEmployeeButton.UseVisualStyleBackColor = true;
            this.SaveEmployeeButton.Click += new System.EventHandler(this.SaveEmployees);
            // 
            // TxtBxEmployeeSurname
            // 
            resources.ApplyResources(this.TxtBxEmployeeSurname, "TxtBxEmployeeSurname");
            this.TxtBxEmployeeSurname.Name = "TxtBxEmployeeSurname";
            this.toolTip1.SetToolTip(this.TxtBxEmployeeSurname, resources.GetString("TxtBxEmployeeSurname.ToolTip"));
            // 
            // TxtBxEmployeeName
            // 
            resources.ApplyResources(this.TxtBxEmployeeName, "TxtBxEmployeeName");
            this.TxtBxEmployeeName.Name = "TxtBxEmployeeName";
            this.toolTip1.SetToolTip(this.TxtBxEmployeeName, resources.GetString("TxtBxEmployeeName.ToolTip"));
            // 
            // EmployeeSurname
            // 
            resources.ApplyResources(this.EmployeeSurname, "EmployeeSurname");
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.toolTip1.SetToolTip(this.EmployeeSurname, resources.GetString("EmployeeSurname.ToolTip"));
            // 
            // EmployeeName
            // 
            resources.ApplyResources(this.EmployeeName, "EmployeeName");
            this.EmployeeName.Name = "EmployeeName";
            this.toolTip1.SetToolTip(this.EmployeeName, resources.GetString("EmployeeName.ToolTip"));
            // 
            // Clock
            // 
            resources.ApplyResources(this.Clock, "Clock");
            this.Clock.Name = "Clock";
            this.toolTip1.SetToolTip(this.Clock, resources.GetString("Clock.ToolTip"));
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer);
            // 
            // languageCmbBx
            // 
            resources.ApplyResources(this.languageCmbBx, "languageCmbBx");
            this.languageCmbBx.FormattingEnabled = true;
            this.languageCmbBx.Name = "languageCmbBx";
            this.toolTip1.SetToolTip(this.languageCmbBx, resources.GetString("languageCmbBx.ToolTip"));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageCmbBx);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.TbCntrl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.loadForm);
            this.TbCntrl.ResumeLayout(false);
            this.AddJbTB.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPriority)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.DeadLinesTab.ResumeLayout(false);
            this.DeadLinesTab.PerformLayout();
            this.Employee.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegisterEmployee.ResumeLayout(false);
            this.tabRegisterEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbCntrl;
        private System.Windows.Forms.TabPage AddJbTB;
        private System.Windows.Forms.TabPage DeadLinesTab;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ShortDescTextBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProjectManagerTextBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectNameTextBx;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndTimeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker StartTimeDate;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSTDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SbTaskName;
        private System.Windows.Forms.TextBox txtSTName;
        /*private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;*/
        private System.Windows.Forms.ComboBox bxEmployeers;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.CheckedListBox lstBxProjects;
        private System.Windows.Forms.Button btnSubTasks;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegisterEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBoxEmployees;
        private System.Windows.Forms.Button SaveEmployeeButton;
        private System.Windows.Forms.TextBox TxtBxEmployeeSurname;
        private System.Windows.Forms.TextBox TxtBxEmployeeName;
        private System.Windows.Forms.Label EmployeeSurname;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.MonthCalendar DeadLinesCalendar;
        private System.Windows.Forms.Label projectListLbl;
        private System.Windows.Forms.ListBox ProjectsNearDeadLinelstbx;
        private System.Windows.Forms.TextBox txtBxSTDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TaskPriority;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox editProjectsChckBox;
        private System.Windows.Forms.Button loadPrEditor;
        private System.Windows.Forms.TextBox ageTxtBx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dniTxtBx;
        private System.Windows.Forms.ComboBox languageCmbBx;
    }
}

