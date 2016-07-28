using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabelaAbcfarmaFirebird
{
    class ClsObjetoTabela
    {

        //LAB_NOM,C,30 nome do produto
        //MED_DES,C,45 descricao do produto
        //MED_APR,C,45  apreciação
        //MED_PCO1,N,12,2  preço de venda
        //MED_FRA1,N,12,2  preço fracionado
        //MED_PRINCI,C,130  printipio ativo
        //MED_BARRA,N,13,0  codigo de barra


        private string med_abc;

        public string Med_abc
        {
            get { return med_abc; }
            set { med_abc = value; }
        }
        private string med_ctr;

        public string Med_ctr
        {
            get { return med_ctr; }
            set { med_ctr = value; }
        }
        private string med_lab;

        public string Med_lab
        {
            get { return med_lab; }
            set { med_lab = value; }
        }
        private string lab_nom;

        public string Lab_nom
        {
            get { return lab_nom; }
            set { lab_nom = value; }
        }
        private string med_des;

        public string Med_des
        {
            get { return med_des; }
            set { med_des = value; }
        }
        private string med_apr;

        public string Med_apr
        {
            get { return med_apr; }
            set { med_apr = value; }
        }
        private double med_pla1;

        public double Med_pla1
        {
            get { return med_pla1; }
            set { med_pla1 = value; }
        }
        private double med_pco1;

        public double Med_pco1
        {
            get { return med_pco1; }
            set { med_pco1 = value; }
        }
        private double med_fra1;

        public double Med_fra1
        {
            get { return med_fra1; }
            set { med_fra1 = value; }
        }
        private int med_uni;

        public int Med_uni
        {
            get { return med_uni; }
            set { med_uni = value; }
        }
        private double med_ipi;

        public double Med_ipi
        {
            get { return med_ipi; }
            set { med_ipi = value; }
        }
        private DateTime med_dtvig;

        public DateTime Med_dtvig
        {
            get { return med_dtvig; }
            set { med_dtvig = value; }
        }
        private bool exp_13;

        public bool Exp_13
        {
            get { return exp_13; }
            set { exp_13 = value; }
        }
        private int med_barra;

        public int Med_barra
        {
            get { return med_barra; }
            set { med_barra = value; }
        }
        private string med_gene;

        public string Med_gene
        {
            get { return med_gene; }
            set { med_gene = value; }
        }
        private string med_negpos;

        public string Med_negpos
        {
            get { return med_negpos; }
            set { med_negpos = value; }
        }
        private string med_princi;

        public string Med_princi
        {
            get { return med_princi; }
            set { med_princi = value; }
        }
        private double med_pla0;

        public double Med_pla0
        {
            get { return med_pla0; }
            set { med_pla0 = value; }
        }
        private double med_pco0;

        public double Med_pco0
        {
            get { return med_pco0; }
            set { med_pco0 = value; }
        }
        private double med_fra0;

        public double Med_fra0
        {
            get { return med_fra0; }
            set { med_fra0 = value; }
        }
        private string med_regims;

        public string Med_regims
        {
            get { return med_regims; }
            set { med_regims = value; }
        }
        private string med_varpre;

        public string Med_varpre
        {
            get { return med_varpre; }
            set { med_varpre = value; }
        }		


    }
}
