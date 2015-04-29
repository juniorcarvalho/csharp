using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe
{
    public class NotaFiscal
    {

    }

    class InfNFe
    {
        public String ID { get; set; }
        public Double Versao { get; set; }
    }

    class RefNF
    {
        public int CUF { get; set; }
        public String AAMM { get; set; }
        public String CNPJ { get; set; }
        public int Modelo { get; set; }
        public int Serie { get; set; }
        public int NNF { get; set; }
    }

    class RefNFP
    {
        public int CUF { get; set; }
        public String AAMM { get; set; }
        public String CNPJ { get; set; }
        public String IE { get; set; }
        public int Modelo { get; set; }
        public int Serie { get; set; }
        public int NNF { get; set; }
    }

    class RefECF
    {
        public Conversao.ECFModRef Modelo { get; set; }
        public String NECF { get; set; }
        public String NCOO { get; set; }
    }

    class refCollectionItem
    {
        public String RefNFe { get; set; }
        public String RefCTe { get; set; }
        public RefNF RefNF { get; set; }
        public RefNFP RefNFP { get; set; }
        public RefECF RefECF { get; set; }
    }

    class Ide
    {
        public int CUF { get; set; }
        public int CNF { get; set; }
        public String NatOp { get; set; }
        public Conversao.IndicadorDePagamento IndicadorDePagamento { get; set; }
        public String Mod { get; set; }
        public String Serie { get; set; }
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
        public String VerProc { get; set; }
        public DateTime DhCont { get; set; }
        public String XJust { get; set; }
    }

    class EnderEmit
    {
        public String XLgr { get; set; }
        public String Nro { get; set; }
        public String XCpl { get; set; }
        public String XBairro { get; set; }
        public int CMun { get; set; }
        public String XMun { get; set; }
        public String UF { get; set; }
        public int CEP { get; set; }
        public int CPais { get; set; }
        public String XPais { get; set; }
        public String Fone { get; set; }
    }

    class Emit
    {
        public String CNPJCPF { get; set; }
        public String XNome { get; set; }
        public String XFant { get; set; }
        public EnderEmit EnderEmit { get; set; }
        public String IE { get; set; }
        public String IEST { get; set; }
        public String IM { get; set; }
        public String CNAE { get; set; }
        public Conversao.CRT CRT { get; set; }
    }

    class Avulsa
    {
        public String CNPJ { get; set; }
        public String XOrgao { get; set; }
        public String Matr { get; set; }
        public String XAgente { get; set; }
        public String Fone { get; set; }
        public String UF { get; set; }
        public String NDAR { get; set; }
        public DateTime DEmi { get; set; }
        public Double VDAR { get; set; }
        public String RepEmi { get; set; }
        public DateTime DPag { get; set; }
    }

    class EnderDest
    {
        public String XLgr { get; set; }
        public String Nro { get; set; }
        public String XCpl { get; set; }
        public String XBairro { get; set; }
        public int CMun { get; set; }
        public String XMun { get; set; }
        public String UF { get; set; }
        public int CEP { get; set; }
        public int CPais { get; set; }
        public String XPais { get; set; }
        public String Fone { get; set; }
    }

    class Dest
    {
        public String CNPJCPF { get; set; }
        public String IDEstrangeiro { get; set; }
        public String XNome { get; set; }
        public EnderEmit EnderEmit { get; set; }
        public Conversao.indIEDest IndIEDest { get; set; }
        public String IE { get; set; }
        public String ISUF { get; set; }
        public String IM { get; set; }
        public String Email { get; set; }
    }

    class Retirada
    {
        public String CNPJCPF { get; set; }
        public String XLgr { get; set; }
        public String Nro { get; set; }
        public String XCpl { get; set; }
        public String XBairro { get; set; }
        public int CMun { get; set; }
        public String XMun { get; set; }
        public String UF { get; set; }
    }

    class Entrega
    {
        public String CNPJCPF { get; set; }
        public String XLgr { get; set; }
        public String Nro { get; set; }
        public String XCpl { get; set; }
        public String XBairro { get; set; }
        public int CMun { get; set; }
        public String XMun { get; set; }
        public String UF { get; set; }
    }

}
