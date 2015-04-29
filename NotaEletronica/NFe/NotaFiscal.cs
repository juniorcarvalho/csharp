using System;
using System.Collections.Generic;

namespace NFe
{
    public class NotaFiscal
    {

    }

    class InfNFe
    {
        public string ID { get; set; }
        public Double Versao { get; set; }
    }

    class RefNF
    {
        public int CUF { get; set; }
        public string AAMM { get; set; }
        public string CNPJ { get; set; }
        public int Modelo { get; set; }
        public int Serie { get; set; }
        public int NNF { get; set; }
    }

    class RefNFP
    {
        public int CUF { get; set; }
        public string AAMM { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public int Modelo { get; set; }
        public int Serie { get; set; }
        public int NNF { get; set; }
    }

    class RefECF
    {
        public Conversao.ECFModRef Modelo { get; set; }
        public string NECF { get; set; }
        public string NCOO { get; set; }
    }

    class refCollectionItem
    {
        public string RefNFe { get; set; }
        public string RefCTe { get; set; }
        public RefNF RefNF { get; set; }
        public RefNFP RefNFP { get; set; }
        public RefECF RefECF { get; set; }
    }

    class Ide
    {
        public int CUF { get; set; }
        public int CNF { get; set; }
        public string NatOp { get; set; }
        public Conversao.IndicadorDePagamento IndicadorDePagamento { get; set; }
        public string Mod { get; set; }
        public string Serie { get; set; }
        public int Nnf { get; set; }
        public DateTime DHEmi { get; set; }
        public DateTime DHSaiEnt { get; set; }
        //public DateTime HSaiEnt { get; set; } // 2.0 , eliminado na 3.1
        public Conversao.TipoNF TpNf { get; set; }
        public Conversao.DestinoOperacao IdDest { get; set; }
        public int cMunFG { get; set; }
        public List<refCollectionItem> NFref { get; set; }
        public Conversao.TipoImpressao TpImp { get; set; }
        public Conversao.TipoEmissao TpEmiss { get; set; }
        public int CDV { get; set; }
        public Conversao.TipoAmbiente TpAmb { get; set; }
        public Conversao.FinalidadeNFe FinNFe { get; set; }
        public Conversao.ConsumidorFinal indFinal { get; set; }
        public Conversao.PresencaComprador indPres { get; set; }
        public Conversao.ProcessoEmissao ProcEmi { get; set; }
        public string VerProc { get; set; }
        public DateTime DhCont { get; set; }
        public string XJust { get; set; }
    }

    class EnderEmit
    {
        public string XLgr { get; set; }
        public string Nro { get; set; }
        public string XCpl { get; set; }
        public string XBairro { get; set; }
        public int CMun { get; set; }
        public string XMun { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public int CPais { get; set; }
        public string XPais { get; set; }
        public string Fone { get; set; }
    }

    class Emit
    {
        public string CNPJCPF { get; set; }
        public string XNome { get; set; }
        public string XFant { get; set; }
        public EnderEmit EnderEmit { get; set; }
        public string IE { get; set; }
        public string IEST { get; set; }
        public string IM { get; set; }
        public string CNAE { get; set; }
        public Conversao.CRT CRT { get; set; }
    }

    class Avulsa
    {
        public string CNPJ { get; set; }
        public string XOrgao { get; set; }
        public string Matr { get; set; }
        public string XAgente { get; set; }
        public string Fone { get; set; }
        public string UF { get; set; }
        public string NDAR { get; set; }
        public DateTime DEmi { get; set; }
        public double VDAR { get; set; }
        public string RepEmi { get; set; }
        public DateTime DPag { get; set; }
    }

    class EnderDest
    {
        public string XLgr { get; set; }
        public string Nro { get; set; }
        public string XCpl { get; set; }
        public string XBairro { get; set; }
        public int CMun { get; set; }
        public string XMun { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public int CPais { get; set; }
        public string XPais { get; set; }
        public string Fone { get; set; }
    }

    class Dest
    {
        public string CNPJCPF { get; set; }
        public string IDEstrangeiro { get; set; }
        public string XNome { get; set; }
        public EnderEmit EnderEmit { get; set; }
        public Conversao.indIEDest IndIEDest { get; set; }
        public string IE { get; set; }
        public string ISUF { get; set; }
        public string IM { get; set; }
        public string Email { get; set; }
    }

    class Retirada
    {
        public string CNPJCPF { get; set; }
        public string XLgr { get; set; }
        public string Nro { get; set; }
        public string XCpl { get; set; }
        public string XBairro { get; set; }
        public int CMun { get; set; }
        public string XMun { get; set; }
        public string UF { get; set; }
    }

    class Entrega
    {
        public string CNPJCPF { get; set; }
        public string XLgr { get; set; }
        public string Nro { get; set; }
        public string XCpl { get; set; }
        public string XBairro { get; set; }
        public int CMun { get; set; }
        public string XMun { get; set; }
        public string UF { get; set; }
    }

    class Adi
    {
        public int NAdicao { get; set; }
        public int NSeqAdicC { get; set; }
        public string CFabricante { get; set; }
        public double VDescDI { get; set; }
        public string NDraw { get; set; }
    }

    class DI
    {
        public string NDI { get; set; }
        public DateTime DDI { get; set; }
        public string XLocDesemb { get; set; }
        public string UFDesemb { get; set; }
        public DateTime DDesemb { get; set; }
        public Conversao.TipoViaTransp TpViaTransp { get; set; }
        public double VAFRMM { get; set; }
        public Conversao.TipoIntermedio TpIntermedio { get; set; }
        public string CNPJ { get; set; }
        public string UFTerceiro { get; set; }
        public List<Adi> Adi { get; set; }

    }

    class DetExport
    {
        public string nDraw { get; set; }
        public string NRE { get; set; }
        public string CHNFe { get; set; }
        public double QExport { get; set; }
    }

    class VeicProd
    {
        public Conversao.TipoOperacao TpOp { get; set; }
        public string Chassi { get; set; }
        public string CCor { get; set; }
        public string XCor { get; set; }
        public string Pot { get; set; }
        public string Cilin { get; set; }
        public string PesoL { get; set; }
        public string PesoB { get; set; }
        public string NSerie { get; set; }
        public string TpComb { get; set; }
        public string NMotor { get; set; }
        public string CMT { get; set; }
        public string Dist { get; set; }
        public int AnoMod { get; set; }
        public int AnoFab { get; set; }
        public string TpPint { get; set; }
        public int TpVeic { get; set; }
        public Conversao.EspecieVeiculo EspVeic { get; set; }
        public string VIN { get; set; }
        public Conversao.CondicaoVeiculo CondVeic { get; set; }
        public string CMod { get; set; }
        public string CCorDENATRAN { get; set; }
        public int Lota { get; set; }
        public Conversao.TipoRestricaoVeiculo TpRest { get; set; }
    }

    class Med
    {
        public string NLote { get; set; }
        public double QLote { get; set; }
        public DateTime DFab { get; set; }
        public DateTime DVal { get; set; }
        public double VPMC { get; set; }
    }

    class Arma
    {
        public Conversao.TipoArma TpArma { get; set; }
        public string NSerie { get; set; }
        public string NCano { get; set; }
        public string Descr { get; set; }

    }

    class CIDE
    {
        public double QBcProd { get; set; }
        public double VAliqProd { get; set; }
        public double VCIDE { get; set; }
    }

    class ICMSComb
    {
        public double VBCICMS { get; set; }
        public double VICMS { get; set; }
        public double VBCICMSST { get; set; }
        public double VICMSST { get; set; }
    }

    class ICMSInter
    {
        public double VBCICMSSTDest { get; set; }
        public double VICMSSTDest { get; set; }
    }

    class ICMSCons
    {
        public double vBCICMSSTCons { get; set; }
        public double vICMSSTCons { get; set; }
        public string UFcons { get; set; }
    }

    class Comb
    {
        public int CProdANP { get; set; }
        public double PMixGN { get; set; }
        public string CODIF { get; set; }
        public double QTemp { get; set; }
        public string UFcons { get; set; }
        public CIDE CIDE { get; set; }
        public ICMSComb ICMS { get; set; }
        public ICMSInter ICMSInter { get; set; }
        public ICMSCons ICMSCons { get; set; }
    }

    class Prod
    {
        public string CProd { get; set; }
        public int NItem { get; set; }
        public string CEAN { get; set; }
        public string XProd { get; set; }
        public string NCM { get; set; }
        public string EXTIPI { get; set; }
        public string CFOP { get; set; }
        public string UCom { get; set; }
        public double QCom { get; set; }
        public double VUnCom { get; set; }
        public double VProd { get; set; }
        public string CEANTrib { get; set; }
        public string UTrib { get; set; }
        public double QTrib { get; set; }
        public double VUnTrib { get; set; }
        public double VFrete { get; set; }
        public double VSeg { get; set; }
        public double VDesc { get; set; }
        public double VOutro { get; set; }
        public Conversao.IndicadorTotal IndTot { get; set; }
        public List<DI> DI { get; set; }
        public string XPed { get; set; }
        public int NItemPed { get; set; }
        public List<DetExport> DetExport { get; set; }
        public VeicProd VeicProd { get; set; }
        public List<Med> Med { get; set; }
        public List<Arma> Arma { get; set; }
        public Comb Comb { get; set; }
        public string NRECOPI { get; set; }
        public string NFCI { get; set; }
    }
}
