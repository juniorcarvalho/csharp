using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe
{
    public static class Conversao
    {
        public enum IndicadorDePagamento { ipVista, ipPrazo, ipOutras };
        public enum TipoNF { entrada, saida };
        public enum DestinoOperacao { doInterna = 1, doInterestadual = 2, doExterior = 3 };
        public enum ECFModRef { ECFModRefVazio, ECFModRef2B, ECFModRef2C, ECFModRef2D };
        public enum TipoImpressao { tiSemGeracao, tiRetrato, tiPaisagem, tiSimplificado, tiNFCe, tiMsgEletronica, tiNFCeA4 };
        public enum TipoEmissao { teNormal = 1, teContingencia = 2, teSCAN = 3, teDPEC = 4, teFSDA = 5, teSVCAN = 6, teSVCRS = 7, teOffLine = 9 };
        public enum TipoAmbiente { taProducao = 1, taHomologacao = 2 };
        public enum FinalidadeNFe { fnNormal = 1, fnComplementar = 2, fnAjuste = 3, fnDevolucao = 4 };
        public enum ProcessoEmissao { peAplicativoContribuinte, peAvulsaFisco, peAvulsaContribuinte, peContribuinteAplicativoFisco };
        public enum ConsumidorFinal { cfNao, cfConsumidorFinal };
        public enum PresencaComprador { pcNao, pcPresencial, pcInternet, pcTeleatendimento, pcEntregaDomicilio, pcOutros = 9 }
        public enum CRT { crtSimplesNacional = 1, crtSimplesExcessoReceita = 2, crtRegimeNormal = 3 }
        public enum indIEDest { inContribuinte = 1, inIsento = 2, inNaoContribuinte = 9 };
    }
}
