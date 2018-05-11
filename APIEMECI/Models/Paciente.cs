//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIEMECI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        public int IdRegistro { get; set; }
        public Nullable<short> Edad { get; set; }
        public string Sexo { get; set; }
        public string Escolaridad { get; set; }
        public int idPaciente { get; set; }
        public string NoTarjeta { get; set; }
        public string grupoRH { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string HospitalNacer { get; set; }
        public string LugarNacer { get; set; }
        public Nullable<byte> AbortosPrevios { get; set; }
        public Nullable<float> PesoNacer { get; set; }
        public Nullable<float> TallaNacer { get; set; }
        public Nullable<float> PerCefalicoNacer { get; set; }
        public string AlergiaMedicina { get; set; }
        public string AlergiaOtros { get; set; }
        public string Patologia { get; set; }
        public string telefonooficina { get; set; }
        public Nullable<byte> Etapa { get; set; }
        public Nullable<byte> TipoEscolaridad { get; set; }
        public string otraescolaridad { get; set; }
        public Nullable<byte> EmbarazoNo { get; set; }
        public string TipoEmbarazo { get; set; }
        public string EmbarazoParto { get; set; }
        public string tipodistocia { get; set; }
        public string tipodistociamencione { get; set; }
        public string motivodistocia { get; set; }
        public string motivodistociamencione { get; set; }
        public Nullable<byte> CalApgarMin { get; set; }
        public Nullable<byte> CalApgar5Min { get; set; }
        public Nullable<byte> CalSilverMin { get; set; }
        public Nullable<byte> CalSilver5Min { get; set; }
        public string Tamizneonatal { get; set; }
        public string NoFolioTamiz { get; set; }
        public string CompINM { get; set; }
        public string CompINMManejo { get; set; }
        public string CompMed { get; set; }
        public string CompMedManejo { get; set; }
        public string lactanciaMat { get; set; }
        public string tipolactancia { get; set; }
        public string nombreformula { get; set; }
        public string motivoreduccion { get; set; }
        public string motivoSuspension { get; set; }
        public Nullable<System.DateTime> fechaConsultaPed { get; set; }
        public string AntecedentePerionatal { get; set; }
        public string rubeola { get; set; }
        public string sarampion { get; set; }
        public string tosferina { get; set; }
        public string roseola { get; set; }
        public string varicela { get; set; }
        public string EnfInfectocontagiosas { get; set; }
        public string EnfContagiosas { get; set; }
        public string EnfContagiosasyEvol { get; set; }
        public string NombrePadre { get; set; }
        public string ApellPaternoPadre { get; set; }
        public string ApellMaternoPadre { get; set; }
        public Nullable<System.DateTime> NacimientoPadre { get; set; }
        public Nullable<int> EstadoCivilPadre { get; set; }
        public Nullable<int> EscolaridadPadre { get; set; }
        public string DetalleEscolaridadPadre { get; set; }
        public Nullable<byte> SaludPadre { get; set; }
        public string DetalleSaludPadre { get; set; }
        public Nullable<bool> toxicomaniaPadre { get; set; }
        public string DetalletoxicomaniaPadre { get; set; }
        public string AntecedentePadre { get; set; }
        public string OtrosAntecedentesPadre { get; set; }
        public string NombreMadre { get; set; }
        public string ApellPaternoMadre { get; set; }
        public string ApellMaternoMadre { get; set; }
        public Nullable<System.DateTime> NacimientoMadre { get; set; }
        public Nullable<int> EstadoCivilMadre { get; set; }
        public Nullable<int> EscolaridadMadre { get; set; }
        public string DetalleEscolaridadMadre { get; set; }
        public Nullable<byte> SaludMadre { get; set; }
        public string DetalleSaludMadre { get; set; }
        public Nullable<bool> toxicomaniaMadre { get; set; }
        public string DetalletoxicomaniaMadre { get; set; }
        public string AntecedenteMadre { get; set; }
        public string OtrosAntecedentesMadre { get; set; }
        public Nullable<int> SostenCefalico { get; set; }
        public Nullable<int> Ablactacion { get; set; }
        public Nullable<int> Posicionsedente { get; set; }
        public Nullable<int> Destete { get; set; }
        public Nullable<int> Guarderia { get; set; }
        public Nullable<int> Jardin { get; set; }
        public Nullable<int> Primaria { get; set; }
        public Nullable<int> Secundaria { get; set; }
        public Nullable<int> Preparatoria { get; set; }
        public Nullable<int> Urbanización { get; set; }
        public Nullable<int> TipodeVivienda { get; set; }
        public Nullable<int> Cohabitantes { get; set; }
        public Nullable<int> caminarSinAyuda { get; set; }
        public Nullable<int> primerasilaba { get; set; }
        public Nullable<int> primeraspalabras { get; set; }
        public string historialclinico { get; set; }
        public string otravacuna { get; set; }
        public string vacunaenfprev { get; set; }
        public string vacunadosis { get; set; }
        public string vacunaedad { get; set; }
        public string vacunafecha { get; set; }
        public string TrataDiagExclusivos { get; set; }
        public string consultas { get; set; }
        public string PreCta { get; set; }
        public string preClave { get; set; }
        public string OtrasConsultas { get; set; }
        public Nullable<byte> mortinatos { get; set; }
        public Nullable<byte> EdadGestal { get; set; }
        public Nullable<byte> tipoEdadGestal { get; set; }
        public Nullable<bool> acepto { get; set; }
        public string ocupacion { get; set; }
        public string religion { get; set; }
        public Nullable<int> EdadMenarca { get; set; }
        public Nullable<int> estadocivil { get; set; }
        public Nullable<int> menacmia { get; set; }
        public Nullable<int> edadPrimerRelacionSexual { get; set; }
        public Nullable<System.DateTime> ultimoPapanicolaou { get; set; }
        public Nullable<System.DateTime> proximoPapanicolaou { get; set; }
        public string estudiosGinecologicos { get; set; }
        public Nullable<bool> dispareunia { get; set; }
        public Nullable<bool> leucorrea { get; set; }
        public string mencioneLeucorrea { get; set; }
        public Nullable<bool> lactorrea { get; set; }
        public Nullable<bool> enfUteroOvarios { get; set; }
        public string mencioneEnfUteroOvarios { get; set; }
        public Nullable<bool> mamografia { get; set; }
        public Nullable<System.DateTime> fechaMamografia { get; set; }
        public Nullable<System.DateTime> fechaProximaMamografia { get; set; }
        public Nullable<bool> procQuirurgico { get; set; }
        public string mencioneProcQuirurgico { get; set; }
        public string observaciones { get; set; }
        public Nullable<System.DateTime> fechaUltimoParto { get; set; }
        public Nullable<System.DateTime> ultimoDiaRegla { get; set; }
        public Nullable<int> gestas { get; set; }
        public Nullable<int> partosNormales { get; set; }
        public Nullable<int> partosAnormales { get; set; }
        public Nullable<int> cesareas { get; set; }
        public Nullable<int> forceps { get; set; }
        public Nullable<int> abortos { get; set; }
        public Nullable<int> malformados { get; set; }
        public Nullable<int> recienNacidosEnfermos { get; set; }
        public Nullable<int> embarazoMultiple { get; set; }
        public Nullable<int> obitos { get; set; }
        public string complicacionEmbarazo { get; set; }
        public string complicacionParto { get; set; }
        public string complicacionRecienNacido { get; set; }
        public string complicacionLact { get; set; }
        public Nullable<int> rnPesoAlto { get; set; }
        public Nullable<int> prematuros { get; set; }
        public string Curp { get; set; }
    }
}
