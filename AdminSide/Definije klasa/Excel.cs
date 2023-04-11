using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using _Excel = Microsoft.Office.Interop.Excel;
using System;

namespace AdminSide
{
    class Excel
    {
        private string path;
        private _Application excel = new _Excel.Application();
        private Workbook wb;
        private Worksheet ws;
        private int kolone;
        private int redovi;

        //konstruktor za pisanje u excel
        public Excel(string path)
        {
            this.path = path;
        }

        //u konstruktoru otvaramo excel file koji smo izabrali
        //biramo odgovarajucu tabelu i brojimo koliko ima redova
        //i kolona tj brojimo do prvog praznog mjesta
        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
            //kolone = ws.Cells.Count;
            //redovi = ws.Rows.Count;
            kolone = ((_Excel.Range)ws.UsedRange.Rows[1, System.Type.Missing]).Columns.Count;
            redovi = ((_Excel.Range)ws.UsedRange.Columns[1, System.Type.Missing]).Rows.Count;
        }
        //kreiramo novi fajl na osnovu template
        //i izaberemo da radimo u prvoj sheetu
        private void CreateFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.ws = wb.Worksheets[1];
        }

        //cuvamo file na odgovarajucem path kojeg smo dobili
        //od save dialoga
        private void SaveAs()
        {
            wb.SaveAs(path);
        }
        

        private void CreateNewSheet()
        {
            Worksheets temp = wb.Worksheets.Add(After: ws);
        }
        
        
        //citamo red po red i ubacujemo u niz vjezbi
        public List<Vjezba> UcitajVjezbe()
        {
            List<Vjezba> lista = new List<Vjezba>();
            int id;
            string naziv = "";
            string ytCode = "";
            string opis = "";
            string tezina, tip, dio;
             Korisnik.Spremnost tezinaVjezbe;
            Vjezba.TipVjezbe tipVjezbe;
            Vjezba.DioTijela dioTijela;
            try
            {
                for (int i = 1; i <= ws.Rows.Count; i++)
                {
                    naziv = (string)ws.Cells[i, 1].Value;
                    ytCode = (string)ws.Cells[i, 2].Value;
                    opis = (string)ws.Cells[i, 3].Value;
                    tezina = (string)ws.Cells[i, 4].Value;
                    tip = (string)ws.Cells[i, 5].Value;
                    dio = (string)ws.Cells[i, 6].Value;
                    tezinaVjezbe = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), tezina);
                    tipVjezbe = (Vjezba.TipVjezbe)Enum.Parse(typeof(Vjezba.TipVjezbe), tip);
                    dioTijela = (Vjezba.DioTijela)Enum.Parse(typeof(Vjezba.DioTijela), dio);
                    lista.Add(new Vjezba(naziv, ytCode, tezinaVjezbe, opis, tipVjezbe, dioTijela));
                }
            }
            catch(Exception ex)
            {

            }
            return lista;
        }

        //funkcija vise vrijednost u odgovarajuce polje excela
        private void WriteCell(int i,int j,object value)
        {
            ws.Cells[i, j].Value = value;
        }

        //prolazimo kroz listu vjezbu i u odgovarajuce polje
        //unosimo vjezbu na kraju se cuvamo na odgovarajucem path
        public void PisiVjezbe(List<Vjezba> v)
        {
            CreateFile();
            for(int i=0;i<v.Count;i++)
            {
                WriteCell(i+1, 1, v[i].Naziv);
                WriteCell(i+1, 2, v[i].YtCode);
                WriteCell(i+1, 3, v[i].Opis);
                WriteCell(i+1, 4, v[i].TezinaVjezbe.ToString());
                WriteCell(i+1, 5, v[i].Tip_Vjezbe.ToString());
                WriteCell(i+1, 6, v[i].Dio_Tijela.ToString());
            }
            SaveAs();
        }

        //da nam ne ostaje konekcija za excelom potrebno
        //ju je zatvoriti
        public void Close()
        {
            wb.Close(false);
            
        }
    }
    

}
