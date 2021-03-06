﻿using LibreriaSistema;
using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorRecursosDidacticos
{
    public partial class Main : Form
    {

        //ToolTip MyToolTip = new ToolTip();//tooltip normal

        ToolTip buttonToolTip = new ToolTip();//tooltip modificado

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            id_planeamiento = 0;
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{}

            

        //private void panel1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is RecursosDidacticos)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }
        //    RecursosDidacticos f2 = new RecursosDidacticos();
        //    f2.Show();
        //}

        //private void TecnicasDidacticas_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is TecnicasDidacticas)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }
        //    TecnicasDidacticas f2 = new TecnicasDidacticas();
        //    f2.Show();
        //}

        //private void ObjetivosContenidos_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is ObjetivosContenidos)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }

        //    DistribucionObjetivos f2 = new SistemaGestorRecursosDidacticos.DistribucionObjetivos();
        //    f2.Show();

        //    //ObjetivosContenidos f2 = new ObjetivosContenidos();
        //    //f2.Show();
        //}

        //private void HistoriaEscuela_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is HistoriaEscuela)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }
        //    HistoriaEscuela f2 = new HistoriaEscuela();
        //    f2.Show();
        //}

        //private void EstrategiasEvaluativas_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is EstrategiasEvaluativas)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }
        //    EstrategiasEvaluativas f2 = new EstrategiasEvaluativas();
        //    f2.Show();
        //}

        //private void DistribucionObjetivos_ClientSizeChanged(object sender, EventArgs e)
        //{
           

        //}

        //private void ItemsPruebaEscrita_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is ItemsPruebaEscrita)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }
        //    ItemsPruebaEscrita f2 = new ItemsPruebaEscrita();
        //    f2.Show();
        //}

        //private void EstrategiasDidacticas_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is EstrategiasDidacticas)
        //        {
        //            frm.Show();
        //            return;
        //        }
        //    }
        //    EstrategiasDidacticas f2 = new EstrategiasDidacticas();
        //    f2.Show();
        //}

        //private void Main_Load(object sender, EventArgs e)
        //{

        //}


        private void btnRecursosDid_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is RecursosDidacticos)
                {
                    frm.Show();
                    return;
                }
            }
            RecursosDidacticos f1 = new SistemaGestorRecursosDidacticos.RecursosDidacticos();
            f1.Show();
        }

        private void btnRecursosDid_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Recursos Didácticos";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnRecursosDid, "Muestra los Recursos Didácticos");
        }

        private void btnTecnicasDid_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is TecnicasDidacticas)
                {
                    frm.Show();
                    return;
                }
            }
            TecnicasDidacticas f2 = new SistemaGestorRecursosDidacticos.TecnicasDidacticas();
            f2.Show();
        }

        private void btnTecnicasDid_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Técnicas Didáctias";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnTecnicasDid, "Muestra las Técnicas Didáctias");
        }

        private void btnObjCont_Click(object sender, EventArgs e)
        {

            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is ObjetivosContenidos)
                {
                    frm.Show();
                    return;
                }
            }
            ObjetivosContenidos f3 = new SistemaGestorRecursosDidacticos.ObjetivosContenidos();
            f3.Show();
        }

        private void btnObjCont_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Objetivos y Contenidos";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnObjCont, "Muestra los Objetivos y Contenidos");
        }

        private void btnPruebaEscr_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is ItemsPruebaEscrita)
                {
                    frm.Show();
                    return;
                }
            }
            ItemsPruebaEscrita f4 = new SistemaGestorRecursosDidacticos.ItemsPruebaEscrita();
            f4.Show();
        }

        private void btnPruebaEscr_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Ítems de Prueba Escrita";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnPruebaEscr, "Muestra los Ítems de Prueba Escrita");
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is HistoriaEscuela)
                {
                    frm.Show();
                    return;
                }
            }
            HistoriaEscuela f5 = new SistemaGestorRecursosDidacticos.HistoriaEscuela();
            f5.Show();
        }

        private void btnHistoria_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Historia de la Escuela";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnHistoria, "Muestra la Historia de la Escuela");
        }

        private void btnEstratEva_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is EstrategiasEvaluativas)
                {
                    frm.Show();
                    return;
                }
            }
            EstrategiasEvaluativas f6 = new SistemaGestorRecursosDidacticos.EstrategiasEvaluativas();
            f6.Show();
        }

        private void btnEstratEva_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Estrategias Evaluativas";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnEstratEva, "Muestra las Estrategias Evaluativas");
        }

        private void btnDistObj_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Planeamiento)
                {
                    frm.Show();
                    return;
                }
            }
            Planeamiento f7 = new SistemaGestorRecursosDidacticos.Planeamiento();
            f7.Show();
        }

        private void btnDistObj_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Distribución de Objetivos";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnDistObj, "Muestra la Distribución de Objetivos");
        }

        private void btnEstratDid_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is EstrategiasDidacticas)
                {
                    frm.Show();
                    return;
                }
            }
            EstrategiasDidacticas f7 = new SistemaGestorRecursosDidacticos.EstrategiasDidacticas();
            f7.Show();
        }

        private void btnEstratDid_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Estrategias Didácticas";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnEstratDid, "Muestra las Estrategias Didácticas");
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            //MyToolTip.Show("Cerrar", btnExit);
            //MyToolTip.Hide(btnCalendar);

            buttonToolTip.ToolTipTitle = "Salir";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnExit, "Salir de la Aplicación");
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Contactos)
                {
                    frm.Show();
                    return;
                }
            }
            Contactos f8 = new SistemaGestorRecursosDidacticos.Contactos();
            f8.Show();
        }

        private void btnCalendar_MouseHover(object sender, EventArgs e)
        {
            //MyToolTip.Show("Calendario", btnCalendar);
            //MyToolTip.Hide(btnCalendar);

            buttonToolTip.ToolTipTitle = "Contactos";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnCalendar, "Ver e Ingresar Contactos");
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Agenda)
                {
                    frm.Show();
                    return;
                }
            }
            Agenda f9 = new SistemaGestorRecursosDidacticos.Agenda();
            f9.Show();
        }

        private void btnAgenda_MouseHover(object sender, EventArgs e)
        {
            //MyToolTip.Show("Agenda", btnAgenda);
            //MyToolTip.Hide(btnCalendar);
            //MyToolTip.ShowAlways = true; 

            
            buttonToolTip.ToolTipTitle = "Agenda";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnAgenda, "Ingresar a la agenda");
        }

       

        private void btnHorario_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Horario";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnHorario, "Ingresar Horario");
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Horario)
                {
                    frm.Show();
                    return;
                }
            }
            Horario f8 = new SistemaGestorRecursosDidacticos.Horario();
            f8.Show();
        }

        private void btnGaleria_MouseHover(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Galeria";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;

            buttonToolTip.ShowAlways = true;

            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;

            buttonToolTip.SetToolTip(btnGaleria, "Ingresar a la Galería");
        }


        private void btnGaleria_Click(object sender, EventArgs e)
        {

            //this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Galeria)
                {
                    frm.Show();
                    return;
                }
            }
            Galeria f8 = new SistemaGestorRecursosDidacticos.Galeria();
            f8.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }





        public static int id_planeamiento { get; set; }
    }
}
