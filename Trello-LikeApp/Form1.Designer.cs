﻿namespace Trello_LikeApp
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
            this.Employee = new System.Windows.Forms.TabPage();
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabRegisterEmployee = new System.Windows.Forms.TabPage();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeSurname = new System.Windows.Forms.Label();
            this.TxtBxEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtBxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.SaveEmployeeButton = new System.Windows.Forms.Button();
            this.lstBoxEmployees = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.TbCntrl.SuspendLayout();
            this.AddJbTB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.Employee.SuspendLayout();
            this.tabRegisterEmployee.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCntrl
            // 
            this.TbCntrl.Controls.Add(this.AddJbTB);
            this.TbCntrl.Controls.Add(this.tabPage2);
            this.TbCntrl.Controls.Add(this.Employee);
            this.TbCntrl.Location = new System.Drawing.Point(2, 12);
            this.TbCntrl.Name = "TbCntrl";
            this.TbCntrl.SelectedIndex = 0;
            this.TbCntrl.Size = new System.Drawing.Size(478, 406);
            this.TbCntrl.TabIndex = 0;
            // 
            // AddJbTB
            // 
            this.AddJbTB.Controls.Add(this.tabControl1);
            this.AddJbTB.Location = new System.Drawing.Point(4, 22);
            this.AddJbTB.Name = "AddJbTB";
            this.AddJbTB.Padding = new System.Windows.Forms.Padding(3);
            this.AddJbTB.Size = new System.Drawing.Size(470, 380);
            this.AddJbTB.TabIndex = 0;
            this.AddJbTB.Text = "Create Project";
            this.AddJbTB.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 380);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.ProjectsLoad);
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Project";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Date";
            // 
            // EndTimeDate
            // 
            this.EndTimeDate.Location = new System.Drawing.Point(250, 186);
            this.EndTimeDate.Name = "EndTimeDate";
            this.EndTimeDate.Size = new System.Drawing.Size(215, 20);
            this.EndTimeDate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Date";
            // 
            // StartTimeDate
            // 
            this.StartTimeDate.Location = new System.Drawing.Point(6, 186);
            this.StartTimeDate.Name = "StartTimeDate";
            this.StartTimeDate.Size = new System.Drawing.Size(214, 20);
            this.StartTimeDate.TabIndex = 14;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(377, 315);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // ShortDescTextBx
            // 
            this.ShortDescTextBx.Location = new System.Drawing.Point(227, 105);
            this.ShortDescTextBx.Name = "ShortDescTextBx";
            this.ShortDescTextBx.Size = new System.Drawing.Size(120, 20);
            this.ShortDescTextBx.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Short Description:";
            // 
            // ProjectManagerTextBx
            // 
            this.ProjectManagerTextBx.Location = new System.Drawing.Point(227, 71);
            this.ProjectManagerTextBx.Name = "ProjectManagerTextBx";
            this.ProjectManagerTextBx.Size = new System.Drawing.Size(120, 20);
            this.ProjectManagerTextBx.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Manager:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project Name:";
            // 
            // ProjectNameTextBx
            // 
            this.ProjectNameTextBx.Location = new System.Drawing.Point(227, 39);
            this.ProjectNameTextBx.Name = "ProjectNameTextBx";
            this.ProjectNameTextBx.Size = new System.Drawing.Size(120, 20);
            this.ProjectNameTextBx.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSubTasks);
            this.tabPage4.Controls.Add(this.lblProjects);
            this.tabPage4.Controls.Add(this.lstBxProjects);
            this.tabPage4.Controls.Add(this.bxEmployeers);
            this.tabPage4.Controls.Add(this.txtSTDescription);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.SbTaskName);
            this.tabPage4.Controls.Add(this.txtSTName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(471, 354);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Add Sub Tasks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSubTasks
            // 
            this.btnSubTasks.Location = new System.Drawing.Point(377, 315);
            this.btnSubTasks.Name = "btnSubTasks";
            this.btnSubTasks.Size = new System.Drawing.Size(75, 23);
            this.btnSubTasks.TabIndex = 22;
            this.btnSubTasks.Text = "Save";
            this.btnSubTasks.UseVisualStyleBackColor = true;
            this.btnSubTasks.Click += new System.EventHandler(this.SaveSubTasks);
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(76, 88);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(45, 13);
            this.lblProjects.TabIndex = 21;
            this.lblProjects.Text = "Projects";
            // 
            // lstBxProjects
            // 
            this.lstBxProjects.FormattingEnabled = true;
            this.lstBxProjects.Location = new System.Drawing.Point(6, 112);
            this.lstBxProjects.Name = "lstBxProjects";
            this.lstBxProjects.Size = new System.Drawing.Size(177, 109);
            this.lstBxProjects.TabIndex = 20;
            this.lstBxProjects.SelectedIndexChanged += new System.EventHandler(this.lstBxProjects_SelectedIndexChanged);
            // 
            // bxEmployeers
            // 
            this.bxEmployeers.FormattingEnabled = true;
            this.bxEmployeers.Location = new System.Drawing.Point(301, 148);
            this.bxEmployeers.Name = "bxEmployeers";
            this.bxEmployeers.Size = new System.Drawing.Size(121, 21);
            this.bxEmployeers.TabIndex = 19;
            // 
            // txtSTDescription
            // 
            this.txtSTDescription.Location = new System.Drawing.Point(301, 182);
            this.txtSTDescription.Name = "txtSTDescription";
            this.txtSTDescription.Size = new System.Drawing.Size(121, 20);
            this.txtSTDescription.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Short Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Employee in charge: ";
            // 
            // SbTaskName
            // 
            this.SbTaskName.AutoSize = true;
            this.SbTaskName.Location = new System.Drawing.Point(204, 119);
            this.SbTaskName.Name = "SbTaskName";
            this.SbTaskName.Size = new System.Drawing.Size(87, 13);
            this.SbTaskName.TabIndex = 14;
            this.SbTaskName.Text = "Sub Task Name:";
            // 
            // txtSTName
            // 
            this.txtSTName.Location = new System.Drawing.Point(301, 116);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.Size = new System.Drawing.Size(121, 20);
            this.txtSTName.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.tabControl2);
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(470, 380);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Employees";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Location = new System.Drawing.Point(432, 9);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(0, 13);
            this.Clock.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer);
            // 
            // tabRegisterEmployee
            // 
            this.tabRegisterEmployee.Controls.Add(this.Refresh_button);
            this.tabRegisterEmployee.Controls.Add(this.label8);
            this.tabRegisterEmployee.Controls.Add(this.lstBoxEmployees);
            this.tabRegisterEmployee.Controls.Add(this.SaveEmployeeButton);
            this.tabRegisterEmployee.Controls.Add(this.TxtBxEmployeeSurname);
            this.tabRegisterEmployee.Controls.Add(this.TxtBxEmployeeName);
            this.tabRegisterEmployee.Controls.Add(this.EmployeeSurname);
            this.tabRegisterEmployee.Controls.Add(this.EmployeeName);
            this.tabRegisterEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabRegisterEmployee.Name = "tabRegisterEmployee";
            this.tabRegisterEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegisterEmployee.Size = new System.Drawing.Size(470, 380);
            this.tabRegisterEmployee.TabIndex = 0;
            this.tabRegisterEmployee.Text = "Register Employee";
            this.tabRegisterEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(134, 45);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(87, 13);
            this.EmployeeName.TabIndex = 6;
            this.EmployeeName.Text = "Employee Name:";
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.AutoSize = true;
            this.EmployeeSurname.Location = new System.Drawing.Point(120, 83);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(101, 13);
            this.EmployeeSurname.TabIndex = 7;
            this.EmployeeSurname.Text = "Employee Surname:";
            // 
            // TxtBxEmployeeName
            // 
            this.TxtBxEmployeeName.Location = new System.Drawing.Point(228, 45);
            this.TxtBxEmployeeName.Name = "TxtBxEmployeeName";
            this.TxtBxEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.TxtBxEmployeeName.TabIndex = 9;
            // 
            // TxtBxEmployeeSurname
            // 
            this.TxtBxEmployeeSurname.Location = new System.Drawing.Point(228, 83);
            this.TxtBxEmployeeSurname.Name = "TxtBxEmployeeSurname";
            this.TxtBxEmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtBxEmployeeSurname.TabIndex = 10;
            // 
            // SaveEmployeeButton
            // 
            this.SaveEmployeeButton.Location = new System.Drawing.Point(377, 315);
            this.SaveEmployeeButton.Name = "SaveEmployeeButton";
            this.SaveEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEmployeeButton.TabIndex = 12;
            this.SaveEmployeeButton.Text = "Save";
            this.SaveEmployeeButton.UseVisualStyleBackColor = true;
            this.SaveEmployeeButton.Click += new System.EventHandler(this.SaveEmployees);
            // 
            // lstBoxEmployees
            // 
            this.lstBoxEmployees.FormattingEnabled = true;
            this.lstBoxEmployees.Location = new System.Drawing.Point(7, 142);
            this.lstBoxEmployees.Name = "lstBoxEmployees";
            this.lstBoxEmployees.Size = new System.Drawing.Size(457, 95);
            this.lstBoxEmployees.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Employees";
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(10, 315);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_button.TabIndex = 24;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.RefreshButtn);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegisterEmployee);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(478, 406);
            this.tabControl2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 418);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.TbCntrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loadForm);
            this.TbCntrl.ResumeLayout(false);
            this.AddJbTB.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.Employee.ResumeLayout(false);
            this.tabRegisterEmployee.ResumeLayout(false);
            this.tabRegisterEmployee.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbCntrl;
        private System.Windows.Forms.TabPage AddJbTB;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBoxEmployees;
        private System.Windows.Forms.Button SaveEmployeeButton;
        private System.Windows.Forms.TextBox TxtBxEmployeeSurname;
        private System.Windows.Forms.TextBox TxtBxEmployeeName;
        private System.Windows.Forms.Label EmployeeSurname;
        private System.Windows.Forms.Label EmployeeName;
    }
}

