using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PersonaModelCreator.Plugins.Models.Measures;
using PersonaModelCreator.Plugins.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaModelCreator.Plugins.Models.Core
{
  internal class CamisaHelper
  {
    public string CriaCamisa(Measures.PersonaCamisaMeasure measure, Models.PersonaCamisa molde, Molde M)
    {
      //SModelos.ItensModelos itensModelos1 = (Modelos.ItensModelos)null;
      double num1 = 0.0;
      string str1 = "";
      bool flag1;
      int num2 = 0;
      double num3;     
      double num4;
      double num5;
      double num6;
      double nMargemCostura;
      double num8;
      double num9;
      double num10;
      double num11;
      double num12;
      double num13;
      double num14;
      double num15;
      double num16;
      bool flag2;
      double num17;
      double num18;
      double num19;
      double num20;
      double num21;
      double num22;
      double num23;
      double num24;
      double num25;
      double num26;
      double num27;
      double num28;
      double num29;
      double num30;
      double num31;
      double ValorRelativoY;
      double val1_1;
      double val2_1;
      double num32;
      double num33;
      double num34;
      double num35;
      double num36;
      double num37;
      double num38;
      double Incremento_X;
      double num39;
      double num40;
      double num41;
      double num42;
      double num43;
      double num44;
      double num45;
      double X;
      double num46 = 0;
      double num47 = 0;
      double num48 = 0;
      double num49 = 0;
      double num50 = 0;
      double num51 = 0;
      double num52 = 0;
      double num53 = 0;
      double num54 = 0;
      double num55 = 0;
      double num56 = 0;
      double num57 = 0;
      double num58 = 0;
      double num59 = 0;
      double num60 = 0;
      double num61 = 0;
      double num62 = 0;
      double num63 = 0;
      double num64 = 0;
      double num65 = 0;
      double num66 = 0;
      double num67 = 0;
      double num68 = 0;
      double num69 = 0;
      double num70 = 0;
      double num71 = 0;
      double num72 = 0;
      double num73 = 0;
      double num74 = 0;
      double num75 = 0;
      double num76 = 0;

      //if (!Information.IsNothing((object)_NomeModelo))
      //{
      //  flag1 = false;
      //  int index = Modelo.BuscaModelo(_NomeModelo);
      //  itensModelos1 = Modelo.Item[index];
      //  Modelos.ItensModelos itensModelos2 = itensModelos1;
      //  num2 = checked((int)System.Math.Round(itensModelos2.get_MedidaMolde("QPC")));
      //  num3 = itensModelos2.get_MedidaMolde("Colarinho");
      //  num4 = itensModelos2.get_MedidaMolde("EspessuraPdG");
      //  num5 = (360.0 - itensModelos2.get_MedidaMolde("AnguloColarinho")) / 360.0 * 2.0 * System.Math.PI;
      //  num6 = itensModelos2.get_MedidaMolde("CompPontaColarinho");
      //  nMargemCostura = itensModelos2.get_MedidaMolde("MargemCostura");
      //  num8 = System.Math.PI / 2.0 - itensModelos2.get_MedidaMolde("AnguloOmbroEsquerdo") / 360.0 * 2.0 * System.Math.PI;
      //  num9 = itensModelos2.get_MedidaMolde("CompOmbroEsquerdo");
      //  num10 = System.Math.PI / 2.0 - itensModelos2.get_MedidaMolde("AnguloOmbroDireito") / 360.0 * 2.0 * System.Math.PI;
      //  num11 = itensModelos2.get_MedidaMolde("CompOmbroDireito");
      //  num12 = itensModelos2.get_MedidaMolde("Torax") / 2.0 - 5.0;
      //  num13 = itensModelos2.get_MedidaMolde("Torax");
      //  num14 = itensModelos2.get_MedidaMolde("FolgaTorax");
      //  num15 = itensModelos2.get_MedidaMolde("MeioPeito");
      //  num16 = itensModelos2.get_MedidaMolde("CompTotal");
      //  flag2 = itensModelos2.get_TemNaOpcaoSelecionada("Sexo", "Masculino");
      //  num17 = itensModelos2.get_MedidaMolde("Cintura");
      //  num18 = itensModelos2.get_MedidaMolde("FolgaCintura");
      //  num19 = itensModelos2.get_MedidaMolde("Quadril");
      //  num20 = itensModelos2.get_MedidaMolde("FolgaQuadril");
      //  num21 = itensModelos2.get_MedidaMolde("FolgaManga");
      //  num22 = itensModelos2.get_MedidaMolde("BarraFrente");
      //  num23 = itensModelos2.get_MedidaMolde("BarraCostas");
      //  num24 = itensModelos2.get_MedidaMolde("QDC");
      //  num25 = itensModelos2.get_MedidaMolde("OmbroOmbro");
      //  num26 = itensModelos2.get_MedidaMolde("PregasCostas");

      //  num27 = System.Math.PI / 2.0 - itensModelos2.get_MedidaMolde("AnguloOmbroDireitoPala") / 360.0 * 2.0 * System.Math.PI;
      //  num28 = -(System.Math.PI / 2.0 - itensModelos2.get_MedidaMolde("AnguloOmbroEsquerdoPala") / 360.0 * 2.0 * System.Math.PI);

      //  num29 = itensModelos2.get_MedidaMolde("MolezaManga");
      //  num30 = itensModelos2.get_MedidaMolde("CompMangaDireita");
      //  num31 = itensModelos2.get_MedidaMolde("CompMangaEsquerda");
      //  ValorRelativoY = itensModelos2.get_MedidaMolde("CompPunho");
      //  val1_1 = itensModelos2.get_MedidaMolde("LarguraPunhoDireito");
      //  val2_1 = itensModelos2.get_MedidaMolde("LarguraPunhoEsquerdo");
      //  num32 = itensModelos2.get_MedidaMolde("TranspassePunho");
      //  num33 = itensModelos2.get_MedidaMolde("LarguraPregasManga");
      //  num34 = itensModelos2.get_MedidaMolde("LevantaTraseiro");
      //  num35 = itensModelos2.get_MedidaMolde("LarguraVistaEsquerda");
      //  num36 = itensModelos2.get_MedidaMolde("LarguraVistaDireita");
      //  num37 = itensModelos2.get_MedidaMolde("PenceBusto");
      //  num38 = itensModelos2.get_MedidaCorpo("PenceBusto");
      //  Incremento_X = itensModelos2.get_MedidaCorpo("PenceBusto");
      //  num39 = itensModelos2.get_MedidaMolde("AlturaPenceFrente");
      //  num40 = itensModelos2.get_MedidaMolde("PenceFrente");
      //  num41 = itensModelos2.get_MedidaCorpo("PenceFrente");
      //  num42 = itensModelos2.get_MedidaMolde("AlturaPenceCostas");
      //  num43 = itensModelos2.get_MedidaMolde("PenceCostas");
      //  num44 = itensModelos2.get_MedidaCorpo("PenceCostas");
      //  num45 = itensModelos2.get_MedidaMolde("CompMangaCurta");

      //  X = 0.0;
      //  num46 = 2.0;
      //  num47 = itensModelos2.get_MedidaCorpo("Ajuste_Aux_Cava_Frente");
      //  num48 = itensModelos2.get_MedidaMolde("Ajuste_Aux_Cava_Frente");
      //  num49 = itensModelos2.get_MedidaMolde("Ajuste_Altura_Cava");
      //  num50 = itensModelos2.get_MedidaCorpo("Ajuste_Torax_Frente");
      //  num51 = itensModelos2.get_MedidaMolde("Ajuste_Altura_Cintura");
      //  num52 = itensModelos2.get_MedidaCor//  num47 = itensModelos2.get_MedidaCorpo("Ajuste_Aux_Cava_Frente");
      //  num48 = itensModelos2.get_MedidaMolde("Ajuste_Aux_Cava_Frente");
      //  num49 = itensModelos2.get_MedidaMolde("Ajuste_Altura_Cava");rpo("Ajuste_Torax_Costas");
      //  num54 = itensModelos2.get_MedidaCorpo("Ajuste_Cintura_Costas");
      //  num55 = itensModelos2.get_MedidaMolde("Ajuste_Altura_Quadril");
      //  num56 = itensModelos2.get_MedidaCorpo("Ajuste_Quadril_Costas");
      //  num57 = itensModelos2.get_MedidaCorpo("Ajuste_Quadril_Frente");
      //  num58 = itensModelos2.get_MedidaCorpo("Ajuste_Aux_Cava_Costas");
      //  num59 = itensModelos2.get_MedidaMolde("Ajuste_Aux_Cava_Costas");
      //  num60 = itensModelos2.get_MedidaCorpo("Ajuste_Meio_Costa");
      //  num61 = itensModelos2.get_MedidaMolde("Ajuste_Altura_Pala");
      //  num62 = itensModelos2.get_MedidaCorpo("Ajuste_Frente_Esquerda_1");
      //  num63 = itensModelos2.get_MedidaMolde("Ajuste_Frente_Esquerda_1");
      //  num64 = itensModelos2.get_MedidaCorpo("Ajuste_Frente_Esquerda_2");
      //  num65 = itensModelos2.get_MedidaMolde("Ajuste_Frente_Esquerda_2");
      //  num66 = itensModelos2.get_MedidaCorpo("Ajuste_Frente_Esquerda_3");
      //  num67 = itensModelos2.get_MedidaMolde("Ajuste_Frente_Esquerda_3");
      //  num68 = itensModelos2.get_MedidaCorpo("Ajuste_Frente_Direita_1");
      //  num69 = itensModelos2.get_MedidaMolde("Ajuste_Frente_Direita_1");
      //  num70 = itensModelos2.get_MedidaCorpo("Ajuste_Frente_Direita_2");
      //  num71 = itensModelos2.get_MedidaMolde("Ajuste_Frente_Direita_2");
      //  num72 = itensModelos2.get_MedidaCorpo("Ajuste_Frente_Direita_3");
      //  num73 = itensModelos2.get_MedidaMolde("Ajuste_Frente_Direita_3");
      //}

      //else
      //{
      flag1 = true;
      //Modelos_Novo.ItensModelos itensModelos2 = ModeloNovo;
      //str1 = ModeloNovo.VersaoArq;
      num2 = 6; //checked((int)System.Math.Round(600.0));
      num3 = measure.Colarinho; // itensModelos2.get_Medida("Colarinho");
      num4 = 4.25; //molde.colitensModelos2.get_Medida("EspessuraColarinho");
      num5 = (360.0 - molde.ColarinhoAngulo) / 360.0 * 2.0 * System.Math.PI;
      num6 = molde.ColarinhoPonta;molde
      nMargemCostura = molde.CosturaLargura;

      num8 = System.Math.PI / 2.0 - molde.OmbroEsquerdoAngulo / 360.0 * 2.0 * System.Math.PI;
      num9 = measure.OmbroEsquerdo;
      num10 = System.Math.PI / 2.0 - molde.OmbroDireitoAngulo / 360.0 * 2.0 * System.Math.PI;
      num11 = measure.OmbroDireito;
      num12 = (measure.Torax/2.0) / 2.0 - 5.0;
      num13 = measure.Torax/2.0;
      num14 = molde.FolgaTorax;
      num74 = 0; //itensModelos2.get_Medida("VariacaoAlturaCarcela1");
      num16 = measure.ComprimentoFrente; // 75; // itensModelos2.get_Medida("CompTotal");

      flag2 = true; //itensModelos2.get_TemNaOpcaoSelecionada("CamisaMasculina", "Sim");

      num17 = measure.Cintura/2; // itensModelos2.get_Medida("Cintura");
      num18 = molde.FolgaCintura; // itensModelos2.get_Medida("FolgaCintura");
      num19 = measure.Quadril/2; // itensModelos2.get_Medida("Quadril");
      num20 = molde.FolgaQuadril; // itensModelos2.get_Medida("FolgaQuadril");
      num21 = 1; //molde.MangaFolga; // itensModelos2.get_Medida("FolgaManga"); **************** mudanca para bater
      num22 = 4.00;// mitensModelos2.get_Medida("BarraFrente");
      num23 = 6.00; // itensModelos2.get_Medida("BarraCostas");
      num24 = 4.00; // itensModelos2.get_Medida("QDC");
      num25 = measure.OmbroAOmbro; //itensModelos2.get_Medida("OmbroOmbro");
      num26 = 1.2; /// molde.TraseiroPregas; // itensModelos2.get_Medida("PregasCostas");************* mudanca para bater
      num27 = System.Math.PI / 2.0 - molde.PalaAnguloDireito / 360.0 * 2.0 * System.Math.PI;
      num28 = -(System.Math.PI / 2.0 - molde.PalaAnguloEsquerdo / 360.0 * 2.0 * System.Math.PI);
      num29 = 2.00; // itensModelos2.get_Medida("MolezaManga");
      num30 = measure.ComprimentoBracoDireito; // measure.comitensModelos2.get_Medida("CompMangaDireita");
      num31 = measure.ComprimentoBracoEsquerdo; // itensModelos2.get_Medida("CompMangaEsquerda");
      ValorRelativoY = 6.50; // itensModelos2.get_Medida("CompPunho");
      val1_1 = measure.PunhoDireito; // itensModelos2.get_Medida("LarguraPunhoDireito");
      val2_1 = measure.PunhoEsquerdo;  //itensModelos2.get_Medida("LarguraPunhoEsquerdo");
      num32 = 4.00; // itensModelos2.get_Medida("TranspassePunho");
      num33 = molde.MangaPregas; // itensModelos2.get_Medida("PregasManga");
      num34 = 0.0; //itensModelos2.get_Medida("LevantaTraseiro");
      num35 = 2.50; // itensModelos2.get_Medida("LarguraVistaEsquerda");
      num36 = 2.00; // itensModelos2.get_Medida("LarguraVistaDireita");
      num37 = 10.00; // itensModelos2.get_Medida("CompPenceBusto");
      num38 = 2.00; // itensModelos2.get_Medida("LargPenceBusto");
      Incremento_X = 2.00;// itensModelos2.get_Medida("LargPenceBusto");
      num39 = 0.0;// itensModelos2.get_Medida("AlturaPenceFrente");
      num40 = 30.00; // itensModelos2.get_Medida("CompPenceFrente");
      num41 = 2.00; // itensModelos2.get_Medida("LargPenceFrente");
      num42 = 0.00; // itensModelos2.get_Medida("AlturaPenceCostas");
      num43 = 35.00; // itensModelos2.get_Medida("CompPenceCostas");
      num44 = 2.00; // itensModelos2.get_Medida("LargPenceCostas");
      num45 = 22.00; // itensModelos2.get_Medida("CompMangaCurta");
      X = 0.0;
      num15 = measure.MeioPeito; // itensModelos2.get_Medida("MeioPeito");
      num46 = 2.00; // itensModelos2.get_Medida("LarguraPenceMasculina");
      num1 = 1.00;// itensModelos2.get_Medida("TamanhoXadrez");
      //itensModelos2.SelecionaOpcao("Tec_Xadrez", "Nao");
      //num47 = itensModelos2.get_Medida("Ajuste_Aux_Cava_Frente_X");
      //num48 = itensModelos2.get_Medida("Ajuste_Aux_Cava_Frente_Y");
      //num49 = itensModelos2.get_Medida("Ajuste_Altura_Cava");
      //num75 = itensModelos2.get_Medida("Ajuste_Altura_Cava_Direita");
      //num76 = itensModelos2.get_Medida("Ajuste_Altura_Cava_Esquerda");
      //num50 = itensModelos2.get_Medida("Ajuste_Torax_Frente");
      //num51 = itensModelos2.get_Medida("Ajuste_Altura_Cintura");
      //num52 = itensModelos2.get_Medida("Ajuste_Cintura_Frente");
      //num53 = itensModelos2.get_Medida("Ajuste_Torax_Costas");
      //num54 = itensModelos2.get_Medida("Ajuste_Cintura_Costas");
      //num55 = itensModelos2.get_Medida("Ajuste_Altura_Quadril");
      //num56 = itensModelos2.get_Medida("Ajuste_Quadril_Costas");
      //num57 = itensModelos2.get_Medida("Ajuste_Quadril_Frente");
      //num58 = itensModelos2.get_Medida("Ajuste_Aux_Cava_Costas_X");
      //num59 = itensModelos2.get_Medida("Ajuste_Aux_Cava_Costas_Y");
      //num60 = itensModelos2.get_Medida("Ajuste_Meio_Costa");
      //num61 = itensModelos2.get_Medida("Ajuste_Altura_Pala");
      //num62 = itensModelos2.get_Medida("Ajuste_Frente_Esquerda_1_X");
      //num63 = itensModelos2.get_Medida("Ajuste_Frente_Esquerda_1_Y");
      //num64 = itensModelos2.get_Medida("Ajuste_Frente_Esquerda_2_X");
      //num65 = itensModelos2.get_Medida("Ajuste_Frente_Esquerda_2_Y");
      //num66 = itensModelos2.get_Medida("Ajuste_Frente_Esquerda_3_X");
      //num67 = itensModelos2.get_Medida("Ajuste_Frente_Esquerda_3_Y");
      //num68 = itensModelos2.get_Medida("Ajuste_Frente_Direita_1_X");
      //num69 = itensModelos2.get_Medida("Ajuste_Frente_Direita_1_Y");
      //num70 = itensModelos2.get_Medida("Ajuste_Frente_Direita_2_X");
      //num71 = itensModelos2.get_Medida("Ajuste_Frente_Direita_2_Y");
      //num72 = itensModelos2.get_Medida("Ajuste_Frente_Direita_3_X");
      //num73 = itensModelos2.get_Medida("Ajuste_Frente_Direita_3_Y");
      //}

      double num77 = num45 + 2.0;
      M.AdicionaMedidaConferencia("Cava Esquerda");
      M.AdicionaMedidaConferencia("Cava Direita");
      M.AdicionaMedidaConferencia("Cabeça Esquerda");
      M.AdicionaMedidaConferencia("Cabeça Direita");
      M.AdicionaMedidaConferencia("Perimetro Colarinho");
      M.AdicionaMedidaConferencia("Perimetro Cava Esquerda");
      M.AdicionaMedidaConferencia("Perimetro Cava Direita");
      string _Nome1 = "Cava";
      M.AdicionaMedidaConferencia(_Nome1);
      double num78 = System.Math.Cos(num8) * num9 * 0.55 + num12;
      double num79 = System.Math.Cos(num10) * num11 * 0.55 + num12;
      System.Math.Max(num79, num78);

      if (!flag2)
      {
        num34 += 4.0;
        num4 -= 0.5;
      }

      double num80 = num24;
      double num81 = num12 + 1.0 + num34 / 3.0;
      double num82 = num80 - (num34 / 3.0 + num34 / 3.0);

      string Left1 = "Comprida";
      string Left2 = "Sem Pregas";

      bool flag3 = false;
      bool flag4 = true;
      bool flag5 = true;
      bool flag6 = true;
      bool flag7 = true;
      bool flag8 = true;
      bool flag9 = true;
      bool flag10 = true;
      bool flag11 = false;
      bool flag12 = true;

      string String1_1 ="";
      string str2;
      string String1_2 = "";

      if (!flag1)
      {
        //if (itensModelos1.get_TemNaOpcaoSelecionada("Manga", "Curta"))
        //  Left1 = "Curta";
        //if (itensModelos1.get_TemNaOpcaoSelecionada("Pregas", "Brita"))
        //  Left2 = "Britanica";
        //if (itensModelos1.get_TemNaOpcaoSelecionada("CortarTecidoDobrado", "True"))
        //  flag3 = true;
        //String1_1 = itensModelos1.get_NomeOpcaoSelecionada("Punho");
        //str2 = itensModelos1.get_NomeOpcaoSelecionada("Vista");
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("VistaContrasteExterno"), "False", CompareMethod.Binary) > 0)
        //  flag4 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("VistaContrasteInterno"), "False", CompareMethod.Binary) > 0)
        //  flag5 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("TecidoXadrez"), "False", CompareMethod.Binary) > 0)
        //  flag10 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("ColarinhoContrasteInterno"), "False", CompareMethod.Binary) > 0)
        //  flag6 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("ColarinhoContrasteExterno"), "False", CompareMethod.Binary) > 0)
        //  flag7 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("PunhoContrasteInterno"), "False", CompareMethod.Binary) > 0)
        //  flag8 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("PunhoContrasteExterno"), "False", CompareMethod.Binary) > 0)
        //  flag9 = false;
        //if (Strings.InStr(itensModelos1.get_NomeOpcaoSelecionada("OpcaoPenceMasculinaCostas"), "Sim", CompareMethod.Binary) > 0)
        //  flag11 = true;
        String1_2 = "Quadrado";
      }
      else
      {
        Left1 = "Comprida";
        Left2 = "Britanica";
        flag3 = false;
        flag12 = false;
        String1_1 = "Quadrado";
        str2 = "Lisa";
        flag4 = false;
        flag5 = false;
        flag10 = false;
        flag6 = false;
        flag7 = false;
        flag8 = false;
        flag9 = false;
        flag11 = false;

        //if (ModeloNovo.get_TemNaOpcaoSelecionada("Manga", "Curta"))
        //  Left1 = "Curta";
        //if (ModeloNovo.get_TemNaOpcaoSelecionada("OpcaoPregas", "Brita"))
        //  Left2 = "Britanica";
        //if (ModeloNovo.get_TemNaOpcaoSelecionada("Tec_Cortar_Dobrado", "Sim"))
        //  flag3 = true;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("ManterCabecasMangasIguais"), "Nao", CompareMethod.Binary) > 0)
        //  flag12 = false;
        //String1_1 = ModeloNovo.get_NomeOpcaoSelecionada("OpcaoPunho");
        //str2 = ModeloNovo.get_NomeOpcaoSelecionada("OpcaoVista");
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("VistaContrasteExterno"), "Nao", CompareMethod.Binary) > 0)
        //  flag4 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("VistaContrasteInterno"), "Nao", CompareMethod.Binary) > 0)
        //  flag5 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("Tec_Xadrez"), "Nao", CompareMethod.Binary) > 0)
        //  flag10 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("ColarinhoContrasteInterno"), "Nao", CompareMethod.Binary) > 0)
        //  flag6 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("ColarinhoContrasteExterno"), "Nao", CompareMethod.Binary) > 0)
        //  flag7 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("PunhoContrasteInterno"), "Nao", CompareMethod.Binary) > 0)
        //  flag8 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("PunhoContrasteExterno"), "Nao", CompareMethod.Binary) > 0)
        //  flag9 = false;
        //if (Strings.InStr(ModeloNovo.get_NomeOpcaoSelecionada("OpcaoPenceMasculinaCostas"), "Sim", CompareMethod.Binary) > 0)
        //  flag11 = true;
        String1_2 = "Quadrado";
      }

      int index1 = M.CriaParte("Frente Esquerda");
      int index2 = M.CriaParte("Frente Direita");
      int Parte1 = M.CriaParte("Costas");
      int ParteCopiada1 = M.CriaParte("Costas Direita");
      int ParteCopiada2 = M.CriaParte("Costas Esquerda");
      int index3 = M.CriaParte("Manga Esquerda");
      int Parte2 = M.CriaParte("Manga Direita");
      int Parte3 = M.CriaParte("Pala");
      int index4 = M.CriaParte("Punho Direito");
      int index5 = M.CriaParte("Punho Esquerdo");
      int index6 = M.CriaParte("Pe Gola Tecido");
      int index7 = M.CriaParte("Gola Tecido");
      int Parte4 = M.CriaParte("Barbatana_");
      int Parte5 = M.CriaParte("Bolso");
      int index8 = M.CriaParte("Pe Gola Colante 1");
      int index9 = M.CriaParte("Gola Colante 1");
      int Parte6 = M.CriaParte("Colante Punho Dir");
      int Parte7 = M.CriaParte("Colante Punho Esq");
      int index10 = M.CriaParte("Pe Gola Colante 2");
      int Parte8 = M.CriaParte("Gola Colante 2");
      int Parte9 = M.CriaParte("Carcela 1");
      int Parte10 = M.CriaParte("Carcela 2");
      int Parte11 = M.CriaParte("Frente");
      int Parte12 = M.CriaParte("Meia Costas");
      int index11 = M.CriaParte("Regua Manga");
      int Parte13 = M.CriaParte("Manga");
      int ParteCopiada3 = M.CriaParte("Aux");

      Parte parte1 = M.Partes[index10];
      parte1.PermiteDesenho = true;
      double num83 = -0.5;
      Parte.Pontos pi1 = parte1.PI;
      pi1.AdicionaPonto("1", 26.36, 0.0);
      pi1.AdicionaPonto("2", 3.04, -199.0 / 425.0 * num4 + num83);
      pi1.AdicionaPontoRelativo("3", "2", 0.0, -13.0 / 85.0 * num4);
      pi1.AdicionaPontoRelativo("4", "3", -201.0 / 100.0, -52.0 / 85.0 * num4);
      pi1.AdicionaPontoRelativo("5", "4", 2.5, -11.0 / 85.0 * num4);
      pi1.AdicionaPonto("6", 26.36, -num4);
      parte1.AdicionaPontoImportante("1", -1, 0);
      parte1.AdicionaCurvaSequencia("2", 0.5857, 41.0 / 625.0, 0.7518, 0.4, num2);
      parte1.AdicionaPontoImportante("3", -1, 0);
      parte1.AdicionaCurvaSequencia("4", 0.72, 0.18, 1.0, 0.36, num2);
      parte1.AdicionaCurvaSequencia("5", 0.3069, 0.826, 0.6237, 0.8695, num2);
      parte1.AdicionaCurvaSequencia("6", 0.2892, 0.4387, 0.5169, 0.8596, num2);

      if (num3 / 2.0 > 23.5)
      {
        parte1.AdicionaPonto(parte1.X[0] + (num3 / 2.0 - 23.0), parte1.Y[0], 0, 0);
        parte1.AdicionaPonto(parte1.X[0], parte1.Y[checked(parte1.QuantPontos - 1)], -1, 0);
      } 

      int index12 = parte1.AdicionaPontoPerimetro(0, parte1.PerimetroEntrePontos(0, parte1.AchaPontoImportante("2", 0), false) - num3 / 2.0);
      int num84 = parte1.AdicionaPontoLinha("X", parte1.X[index12], checked(index12 + 3));
      int num85 = checked(parte1.QuantPontos - 1);
      int num86 = checked(num84 + 1);
      int num87 = num85;
      int num88 = num86;

      while (num88 <= num87)
      {
        parte1.ExcluePonto(checked(num84 + 1));
        checked { ++num88; }
      }

      int num89 = 0;
      int num90 = checked(index12 - 1);
      int num91 = num89;

      while (num91 <= num90)
      {
        parte1.ExcluePonto(0);
        checked { ++num91; }
      }

      double Peri_Colarinho = 0.0;

      //if (!flag1)
      //  itensModelos1.set_MedidaCorpo("Peri_Colarinho", parte1.PerimetroEntrePontos(parte1.AchaPontoImportante("4", 0), checked(parte1.QuantPontos - 1), false) * 2.0);
      //else
      //  //ModeloNovo.set_Medida("Peri_Colarinho", parte1.PerimetroEntrePontos(parte1.AchaPontoImportante("4", 0), checked(parte1.QuantPontos - 1), false) * 2.0);
      Peri_Colarinho = parte1.PerimetroEntrePontos(parte1.AchaPontoImportante("4", 0), checked(parte1.QuantPontos - 1), false) * 2.0;

      M.set_MedidaConferencia("Perimetro Colarinho", 2, parte1.PerimetroEntrePontos(parte1.AchaPontoImportante("4", 0), checked(parte1.QuantPontos - 1), false) * 2.0);
      Parte parte2 = M.Partes[index6];
      parte2.PermiteDesenho = true;
      parte2.Gabarito = false;
      double num92 = -0.5;
      double num93 = num4 + 1.0;
      Parte.Pontos pi2 = parte2.PI;
      pi2.AdicionaPonto("1", 26.36, 0.0);
      pi2.AdicionaPonto("2", 3.04, -199.0 / 425.0 * num93 + num92);
      pi2.AdicionaPontoRelativo("3", "2", -201.0 / 100.0, -52.0 / 85.0 * num93);
      pi2.AdicionaPontoRelativo("4", "3", 2.5, -11.0 / 85.0 * num93);
      pi2.AdicionaPonto("5", 26.36, -num93);
      parte2.AdicionaPontoImportante("1", -1, 0);
      parte2.AdicionaCurvaSequencia("2", 0.5857, 41.0 / 625.0, 0.7518, 0.4, num2);
      parte2.AdicionaCurvaSequencia("3", 0.72, 0.18, 1.0, 0.36, num2);
      parte2.AdicionaCurvaSequencia("4", 0.3069, 0.826, 0.6237, 0.8695, num2);
      parte2.AdicionaCurvaSequencia("5", 0.2892, 0.4387, 0.5169, 0.8596, num2);

      if (num3 / 2.0 > 23.5)
      {
        parte2.AdicionaPonto(parte2.X[0] + (num3 / 2.0 - 22.0), parte2.Y[0], 0, 0);
        parte2.AdicionaPonto(parte2.X[0], parte2.Y[checked(parte2.QuantPontos - 1)], -1, 0);
      }
      else
      {
        parte2.AdicionaPonto(parte2.X[0] + 1.0, parte2.Y[0], 0, 0);
        parte2.AdicionaPonto(parte2.X[0], parte2.Y[checked(parte2.QuantPontos - 1)], -1, 0);
      }
      double num94 = M.Partes[index10].X[M.Partes[index10].AchaPontoImportante("4", 0)] - M.Partes[index10].X[0];
      int index13 = parte2.AdicionaPontoLinha("X", parte2.PI.get_X("3") - num94, 0);
      int num95 = parte2.AdicionaPontoLinha("X", parte2.X[index13], parte2.AchaPontoImportante("3", 0));
      int num96 = checked(parte2.QuantPontos - 1);
      int num97 = checked(num95 + 1);
      int num98 = num96;
      int num99 = num97;
      while (num99 <= num98)
      {
        parte2.ExcluePonto(checked(num95 + 1));
        checked { ++num99; }
      }
      int num100 = 0;
      int num101 = checked(index13 - 1);
      int num102 = num100;
      while (num102 <= num101)
      {
        parte2.ExcluePonto(0);
        checked { ++num102; }
      }
      Parte parte3 = M.Partes[index8];
      parte3.PermiteDesenho = true;
      parte3.Gabarito = false;
      double num103 = -1.15;
      double num104 = num4;
      Parte.Pontos pi3 = parte3.PI;
      pi3.AdicionaPonto("1", 26.36, -0.65);
      pi3.AdicionaPonto("2", 3.04, -199.0 / 425.0 * num104 + num103);
      pi3.AdicionaPontoRelativo("3", "2", -201.0 / 100.0, -52.0 / 85.0 * num104);
      pi3.AdicionaPontoRelativo("4", "3", 2.5, -11.0 / 85.0 * num104);
      pi3.AdicionaPonto("5", 26.36, -num104);
      parte3.AdicionaPontoImportante("1", -1, 0);
      parte3.AdicionaCurvaSequencia("2", 0.5857, 41.0 / 625.0, 0.7518, 0.4, num2);
      parte3.AdicionaCurvaSequencia("3", 0.72, 0.18, 1.0, 0.36, num2);
      parte3.AdicionaCurvaSequencia("4", 0.3069, 0.826, 0.6237, 0.8695, num2);
      parte3.AdicionaCurvaSequencia("5", 0.2892, 0.4387, 0.5169, 0.8596, num2);
      if (num3 / 2.0 > 23.5)
      {
        parte3.AdicionaPonto(parte3.X[0] + (num3 / 2.0 - 23.0), parte3.Y[0], 0, 0);
        parte3.AdicionaPonto(parte3.X[0], parte3.Y[checked(parte3.QuantPontos - 1)], -1, 0);
      }
      int index14 = parte3.AdicionaPontoPerimetro(0, parte3.PerimetroEntrePontos(0, parte3.AchaPontoImportante("2", 0), false) - num3 / 2.0);
      int num105 = parte3.AdicionaPontoLinha("X", parte3.X[index14], checked(index14 + 3));
      int num106 = checked(parte3.QuantPontos - 1);
      int num107 = checked(num105 + 1);
      int num108 = num106;
      int num109 = num107;
      while (num109 <= num108)
      {
        parte3.ExcluePonto(checked(num105 + 1));
        checked { ++num109; }
      }
      int num110 = 0;
      int num111 = checked(index14 - 1);
      int num112 = num110;
      while (num112 <= num111)
      {
        parte3.ExcluePonto(0);
        checked { ++num112; }
      }
      Parte parte4 = M.Partes[index10]; 
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index10, 0, 0, false, false);
      M.Partes[ParteCopiada3].InverteCordenadas(true, false);
      parte4.CopiaParte(M, ParteCopiada3, 0, 0, false, false);
      M.Partes[ParteCopiada3].LimpaParte(false);
      parte4.RetiraPontosIguais();
      parte4.GiraParteNovo(System.Math.PI / 4.0, 0);
      parte4.Ampliacao(0.01);
      Parte parte5 = M.Partes[index8];
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index8, 0, 0, false, false);
      M.Partes[ParteCopiada3].InverteCordenadas(true, false);
      parte5.CopiaParte(M, ParteCopiada3, 0, 0, false, false);
      M.Partes[ParteCopiada3].LimpaParte(false);
      parte5.RetiraPontosIguais();
      parte5.GiraParteNovo(System.Math.PI / 4.0, 0);
      parte5.Ampliacao(0.01);
      Parte parte6 = M.Partes[index6];
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index6, 0, 0, false, false);
      M.Partes[ParteCopiada3].InverteCordenadas(true, false);
      parte6.CopiaParte(M, ParteCopiada3, 0, 0, false, false);
      M.Partes[ParteCopiada3].LimpaParte(false);
      parte6.TrocaPontoZero(parte6.AchaPontoImportante("3", 0), false);
      parte6.Ampliacao(nMargemCostura);
      parte6.TransformaPiquesAmp();
      Parte parte7 = M.Partes[index9];
      parte7.PermiteDesenho = true;
      parte7.Gabarito = false;
      double Y1 = num4;
      Parte.Pontos pi4 = parte7.PI;
      pi4.AdicionaPonto("1", 0.0, 0.0);
      pi4.AdicionaPonto("2", 17.21, 0.16 * Y1);
      pi4.AdicionaPonto("3", 24.45 + System.Math.Cos(num5) * num6, 1.4 * Y1 + System.Math.Sin(num5) * num6);
      pi4.AdicionaPonto("4", 24.45, 1.4 * Y1);
      pi4.AdicionaPonto("5", 0.0, Y1);
      parte7.AdicionaPontoImportante("1", -1, 0);
      parte7.AdicionaCurvaSequencia("2", 0.3972, 0.1219, 0.6245, 503.0 / 625.0, num2);
      parte7.AdicionaCurvaSequencia("3", 0.3786, 0.1656, 0.7067, 0.7131, num2);
      parte7.AdicionaPontoImportante("4", -1, 0);
      parte7.AdicionaCurvaSequencia("5", 0.3659, 0.8644, 0.6691, 0.9322, num2);
      if (num3 / 2.0 > 23.5)
      {
        parte7.AdicionaPonto(parte7.X[0] - (num3 / 2.0 - 23.0), parte7.Y[0], 0, 0);
        parte7.AdicionaPonto(parte7.X[0], parte7.Y[checked(parte7.QuantPontos - 1)], -1, 0);
      }
      int index15 = parte7.AdicionaPontoPerimetro(parte7.AchaPontoImportante("4", 0), num3 / 2.0);
      parte7.PI.AdicionaPonto("4a", parte7.X[index15], parte7.Y[index15]);
      int num113 = parte7.AdicionaPontoLinha("X", parte7.X[index15], 0);
      int num114 = parte7.AchaPontoImportante("4a", 0);
      int num115 = checked(parte7.QuantPontos - 1);
      int num116 = checked(num114 + 1);
      int num117 = num115;
      int num118 = num116;
      while (num118 <= num117)
      {
        parte7.ExcluePonto(checked(num114 + 1));
        checked { ++num118; }
      }
      int num119 = 0;
      int num120 = checked(num113 - 1);
      int num121 = num119;
      while (num121 <= num120)
      {
        parte7.ExcluePonto(0);
        checked { ++num121; }
      }
      Parte parte8 = M.Partes[index7];
      parte8.PermiteDesenho = true;
      parte8.Gabarito = false;
      double Y2 = num4 + 2.0;
      double num122 = num6 + 2.0;
      Parte.Pontos pi5 = parte8.PI;
      pi5.AdicionaPonto("1", 0.0, 0.0);
      pi5.AdicionaPonto("2", 17.21, 0.16 * Y2);
      pi5.AdicionaPonto("3", 24.45 + System.Math.Cos(num5) * num122, 1.4 * Y2 + System.Math.Sin(num5) * num122);
      pi5.AdicionaPonto("4", 24.45, 1.4 * Y2);
      pi5.AdicionaPonto("5", 0.0, Y2);
      parte8.AdicionaPontoImportante("1", -1, 0);
      parte8.AdicionaCurvaSequencia("2", 0.3972, 0.1219, 0.6245, 503.0 / 625.0, num2);
      parte8.AdicionaCurvaSequencia("3", 0.3786, 0.1656, 0.7067, 0.7131, num2);
      parte8.AdicionaPontoImportante("4", -1, 0);
      parte8.AdicionaCurvaSequencia("5", 0.3659, 0.8644, 0.6691, 0.9322, num2);
      if (num3 / 2.0 > 23.5)
      {
        parte8.AdicionaPonto(parte8.X[0] - (num3 / 2.0 - 23.0), parte8.Y[0], 0, 0);
        parte8.AdicionaPonto(parte8.X[0], parte8.Y[checked(parte8.QuantPontos - 1)], -1, 0);
      }
      int index16 = parte8.AdicionaPontoPerimetro(parte8.AchaPontoImportante("4", 0), num3 / 2.0);
      parte8.PI.AdicionaPonto("4a", parte8.X[index16], parte8.Y[index16]);
      int num123 = parte8.AdicionaPontoLinha("X", parte8.X[index16], 0);
      int num124 = parte8.AchaPontoImportante("4a", 0);
      int num125 = checked(parte8.QuantPontos - 1);
      int num126 = checked(num124 + 1);
      int num127 = num125;
      int num128 = num126;
      while (num128 <= num127)
      {
        parte8.ExcluePonto(checked(num124 + 1));
        checked { ++num128; }
      }
      int num129 = 0;
      int num130 = checked(num123 - 1);
      int num131 = num129;
      while (num131 <= num130)
      {
        parte8.ExcluePonto(0);
        checked { ++num131; }
      }
      Parte parte9 = M.Partes[index7];
      parte9.LimpaParte(false);
      parte9.PermiteDesenho = true;
      parte9.CopiaParte(M, index9, 0, 0, true, false);
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index9, 0, 0, false, false);
      M.Partes[ParteCopiada3].InverteCordenadas(true, false);
      parte9.CopiaParte(M, ParteCopiada3, 0, 0, false, false);
      M.Partes[ParteCopiada3].LimpaParte(false);
      parte9.RetiraPontosIguais();
      parte9.TrocaPontoZero(parte9.AchaPontoImportante("3", 0), false);
      parte9.Ampliacao(nMargemCostura + 0.75);
      parte9.TransformaPiquesAmp();
      Parte parte10 = M.Partes[index9];
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index9, 0, 0, false, false);
      M.Partes[ParteCopiada3].InverteCordenadas(true, false);
      parte10.CopiaParte(M, ParteCopiada3, 0, 0, false, false);
      M.Partes[ParteCopiada3].LimpaParte(false);
      parte10.RetiraPontosIguais();
      parte10.GiraParteNovo(System.Math.PI / 4.0, 0);
      parte10.Ampliacao(0.01);
      Parte parte11 = M.Partes[Parte8];
      parte11.PermiteDesenho = true;
      parte11.CopiaParte(M, index9, 0, 0, false, false);
      parte11.Ampliacao(nMargemCostura);
      Parte parte12 = M.Partes[index1];


      //parte12.pCurva[0] = 1; // 2 erro
      //parte12.pCurva[1] = 1;
      //parte12.pCurva[2] = 1;
      //parte12.pCurva[3] = 1;
      //parte12.pCurva[4] = 1;
      //parte12.pCurva[5] = 2;
      //parte12.pCurva[6] = 1; // 2 trava
      //parte12.pCurva[7] = 2;
      //parte12.pCurva[8] = 4;


      //parte12.pCurva[0] = 1;
      //parte12.pCurva[1] = 1;
      //parte12.pCurva[2] = 1;
      //parte12.pCurva[3] = 1;
      //parte12.pCurva[4] = 2;
      //parte12.pCurva[5] = 1;
      //parte12.pCurva[6] = 1;
      //parte12.pCurva[7] = 2;
      //parte12.pCurva[8] = 2;



      parte12.RespeitaXadrez = true;
      parte12.PermiteDesenho = true;
      parte12.Gabarito = false;
      Parte.Pontos pi6 = parte12.PI;
      pi6.AdicionaPonto("A", num3 / 6.0, 1.0);
      pi6.AdicionaPonto("B", -nMargemCostura, -(num3 / 6.0 + nMargemCostura * -0.3));
      pi6.AdicionaPonto("C", pi6.get_X("B") + System.Math.Cos(num8) * num9, pi6.get_Y("B") - System.Math.Sin(num8) * num9);
      pi6.AdicionaPonto("D", pi6.get_X("B") + (pi6.get_X("C") - pi6.get_X("B")) * 0.55, pi6.get_Y("B") + (pi6.get_Y("C") - pi6.get_Y("B")) * 0.55);
      pi6.AdicionaPonto("F", num78, -(num13 / 2.0 + num14));
      if (flag2)
        pi6.AdicionaPonto("E", (pi6.get_X("F") - pi6.get_X("B")) / 2.0, -(num15 - nMargemCostura));
      else
        pi6.AdicionaPonto("E", (pi6.get_X("F") - pi6.get_X("B")) / 2.0, -(num15 * 0.85 - nMargemCostura));
      pi6.AdicionaPonto("J", pi6.get_X("A") - num3 / 6.0 - nMargemCostura + num16, pi6.get_Y("A"));
      if (X == 0.0)
        X = pi6.get_X("F") + (pi6.get_X("J") - pi6.get_X("F")) * 0.35;
      pi6.AdicionaPonto("G", X, -(num17 / 2.0 + num18));
      pi6.AdicionaPonto("H", pi6.get_X("F") + (pi6.get_X("J") - pi6.get_X("F")) * 0.8, -(num19 / 2.0 + num20));
      pi6.AtualizaPonto("E", -num48, -num47);
      pi6.AtualizaPonto("F", -num49 - num76, -num50);
      pi6.AtualizaPonto("G", -num51, -num52);
      pi6.AtualizaPonto("H", -num55, -num57);
      pi6.AtualizaPonto("B", -num63, -num62);
      pi6.AtualizaPonto("D", -num65, -num64);
      pi6.AtualizaPonto("C", -num67, -num66);
      if (pi6.get_Y("H") < pi6.get_Y("G"))
        pi6.AdicionaPonto("I", pi6.get_X("J") - num22, pi6.get_Y("H") - 0.25);
      else
        pi6.AdicionaPonto("I", pi6.get_X("J") - num22, -(pi6.get_X("G") - (pi6.get_X("J") - num22)) * (pi6.get_Y("G") - pi6.get_Y("H")) / (pi6.get_X("G") - pi6.get_X("H")) + pi6.get_Y("G"));
      if (!flag2)
      {
        parte12.PI.AtualizaPonto("G", Incremento_X, 0.0);
        parte12.PI.AtualizaPonto("H", Incremento_X, 0.0);
      }
      parte12.AdicionaPontoImportante("A", -1, 0);
      parte12.AdicionaCurvaSequencia("B", 0.0115, 0.6573, 0.471, 0.8565, num2);
      parte12.AdicionaPontoImportante("D", -1, 0);
      parte12.AdicionaPontoImportante("C", -1, 0);
      parte12.AdicionaCurvaSequencia("E", 218.0 / 625.0, 0.4482, 0.6569, 0.7931, num2);
      parte12.AdicionaCurvaSequencia("F", 0.8362, -0.1111, 0.8989, 0.6172, num2);
      parte12.AdicionaCurvaSequencia("G", 0.2921, 0.3773, 0.7078, 566.0 / 625.0, num2);
      parte12.AdicionaCurvaSequencia("H", 0.4874, 0.0462, 0.6147, 0.8033, num2);
      parte12.AdicionaCurvaSequencia("I", 0.298, 0.4073, 0.589, 0.6613, num2);
      parte12.AdicionaCurvaSequencia("J", 0.695, 0.2302, 1.0695, 198.0 / 625.0, num2);
      int index17 = parte12.AdicionaPontoLinha("Y", parte12.Y[0] - 1.0, parte12.AchaPontoImportante("G", 0));
      parte12.PI.AdicionaPonto("M2", parte12.X[index17], parte12.Y[index17]);
      int index18 = parte12.AdicionaPontoLinha("Y", parte12.Y[0] - 1.0, 0);
      parte12.PI.AdicionaPonto("M1", parte12.X[index18], parte12.Y[index18]);
      Molde molde1 = M;
      Molde molde2 = molde1;

      string _Nome2 = _Nome1;
      string _Nome3 = _Nome2;
      int _QualMedida1 = 1;
      int _QualMedida2 = _QualMedida1;

      double num132 = molde1.get_MedidaConferencia(_Nome2, _QualMedida1) + parte12.PerimetroEntrePontos("C", "F");
      
      molde2.set_MedidaConferencia(_Nome3, _QualMedida2, num132);

      double num133 = parte12.PerimetroEntrePontos("C", "F");
      M.set_MedidaConferencia("Cava Esquerda", 2, parte12.PerimetroEntrePontos("C", "F"));
     
     
      int index19 = parte12.AdicionaPontoPerimetro(parte12.AchaPontoImportante("M1", 0), parte12.PerimetroEntrePontos("M1", "B") / 2.0);
      parte12.PI.AdicionaPonto("Col1", parte12.X[index19], parte12.Y[index19]);
      
      if (flag2)
      {
        M.AdicionaMedidaConferencia("med");
        M.set_MedidaConferencia("med", 1, parte12.PerimetroEntrePontos("F", "H"));
        M.AdicionaMedidaConferencia("med1");
        M.set_MedidaConferencia("med1", 1, parte12.PerimetroEntrePontos("F", "H"));
      }

      Parte parte13 = M.Partes[index2];
      parte13.RespeitaXadrez = true;
      parte13.PermiteDesenho = true;
      parte13.Gabarito = false;
      Parte.Pontos pi7 = parte13.PI;
      pi7.AdicionaPonto("A", num3 / 6.0, 1.0);
      pi7.AdicionaPonto("B", -nMargemCostura, -(num3 / 6.0 + nMargemCostura * -0.3));
      pi7.AdicionaPonto("C", pi7.get_X("B") + System.Math.Cos(num10) * num11, pi7.get_Y("B") - System.Math.Sin(num10) * num11);
      pi7.AdicionaPonto("D", pi7.get_X("B") + (pi7.get_X("C") - pi7.get_X("B")) * 0.55, pi7.get_Y("B") + (pi7.get_Y("C") - pi7.get_Y("B")) * 0.55);
      pi7.AdicionaPonto("F", num79, -(num13 / 2.0 + num14));
      
      if (flag2)
        pi7.AdicionaPonto("E", (pi7.get_X("F") - pi7.get_X("B")) / 2.0, -(num15 - nMargemCostura));
      else
        pi7.AdicionaPonto("E", (pi7.get_X("F") - pi7.get_X("B")) / 2.0, -(num15 * 0.85 - nMargemCostura));
      pi7.AdicionaPonto("J", pi7.get_X("A") - num3 / 6.0 - nMargemCostura + num16, pi7.get_Y("A"));
      
      if (X == 0.0)
        X = pi7.get_X("F") + (pi7.get_X("J") - pi7.get_X("F")) * 0.35;
      pi7.AdicionaPonto("G", X, -(num17 / 2.0 + num18));
      pi7.AdicionaPonto("H", pi7.get_X("F") + (pi7.get_X("J") - pi7.get_X("F")) * 0.8, -(num19 / 2.0 + num20));
      pi7.AtualizaPonto("E", -num48, -num47);
      pi7.AtualizaPonto("F", -num49 - num75, -num50);
      pi7.AtualizaPonto("F_Ori", -num49, -num50);
      pi7.AtualizaPonto("G", -num51, -num52);
      pi7.AtualizaPonto("H", -num55, -num57);
      pi7.AtualizaPonto("B", -num69, -num68);
      pi7.AtualizaPonto("D", -num71, -num70);
      pi7.AtualizaPonto("C", -num73, -num72);
     
      if (pi7.get_Y("H") < pi7.get_Y("G"))
        pi7.AdicionaPonto("I", pi7.get_X("J") - num22, pi7.get_Y("H") - 0.25);
      else
        pi7.AdicionaPonto("I", pi7.get_X("J") - num22, -(pi7.get_X("G") - (pi7.get_X("J") - num22)) * (pi7.get_Y("G") - pi7.get_Y("H")) / (pi7.get_X("G") - pi7.get_X("H")) + pi7.get_Y("G"));
      if (!flag2)
      {
        parte13.PI.AtualizaPonto("G", Incremento_X, 0.0);
        parte13.PI.AtualizaPonto("H", Incremento_X, 0.0);
      }
      
      parte13.AdicionaPontoImportante("A", -1, 0);
      parte13.AdicionaCurvaSequencia("B", 0.0115, 0.6573, 0.471, 0.8565, num2);
      parte13.AdicionaPontoImportante("D", -1, 0);
      parte13.AdicionaPontoImportante("C", -1, 0);
      parte13.AdicionaCurvaSequencia("E", 218.0 / 625.0, 0.4482, 0.6569, 0.7931, num2);
      parte13.AdicionaCurvaSequencia("F", 0.8362, -0.1111, 0.8989, 0.6172, num2);
      parte13.AdicionaCurvaSequencia("G", 0.2921, 0.3773, 0.7078, 566.0 / 625.0, num2);
      parte13.AdicionaCurvaSequencia("H", 0.4874, 0.0462, 0.6147, 0.8033, num2);
      parte13.AdicionaCurvaSequencia("I", 0.298, 0.4073, 0.589, 0.6613, num2);
      parte13.AdicionaCurvaSequencia("J", 0.695, 0.2302, 1.0695, 198.0 / 625.0, num2);
      int index20 = parte13.AdicionaPontoLinha("Y", parte13.Y[0] - 1.0, parte13.AchaPontoImportante("G", 0));
      parte13.PI.AdicionaPonto("M2", parte13.X[index20], parte13.Y[index20]);
      int index21 = parte13.AdicionaPontoLinha("Y", parte13.Y[0] - 1.0, 0);
      parte13.PI.AdicionaPonto("M1", parte13.X[index21], parte13.Y[index21]);
      M.set_MedidaConferencia("Cava Direita", 2, parte13.PerimetroEntrePontos("C", "F"));
      parte13.InverteCordenadas(false, true);
      Molde molde3 = M;
      Molde molde4 = molde3;

      string _Nome4 = _Nome1;
      string _Nome5 = _Nome4;
      int _QualMedida3 = 2;
      int _QualMedida4 = _QualMedida3;
      double num134 = molde3.get_MedidaConferencia(_Nome4, _QualMedida3) + parte13.PerimetroEntrePontos("F", "C");
      molde4.set_MedidaConferencia(_Nome5, _QualMedida4, num134);
      double num135 = parte13.PerimetroEntrePontos("F", "C");
      Parte parte14 = M.Partes[Parte3];
      parte14.PermiteDesenho = true;
      parte14.Gabarito = false;
      Parte.Pontos pi8 = parte14.PI;
      pi8.AdicionaPonto("A", 5.0, 0.0);
      pi8.AdicionaPonto("B", nMargemCostura * 0.6, -(num3 / 6.0 + nMargemCostura * 1.1));
      pi8.AdicionaPonto("B1", nMargemCostura * 0.6, num3 / 6.0 + nMargemCostura * 1.1);
      pi8.AdicionaPonto("Cd", pi8.get_X("B") + System.Math.Cos(num27) * num11, pi8.get_Y("B") - System.Math.Sin(num27) * num11);
      pi8.AdicionaPonto("Ce", pi8.get_X("B") + System.Math.Cos(num28) * num9, -pi8.get_Y("B") - System.Math.Sin(num28) * num9);
      pi8.AdicionaPonto("D", 15.0 - 2.0 * nMargemCostura, -(num25 / 2.0 - nMargemCostura));
      if (!flag2)
        pi8.AtualizaPonto("D", -1.5, 0.0);
      pi8.AtualizaPonto("D", -num61, -num60);
      pi8.AdicionaPonto("D1", pi8.get_X("D"), -pi8.get_Y("D"));
      parte14.AdicionaPontoImportante("A", -1, 0);
      parte14.AdicionaCurvaSequencia("B", 0.0327, 0.6951, 0.4581, 0.8276, num2);
      parte14.AdicionaPontoImportante("Cd", -1, 0);
      parte14.AdicionaCurvaSequencia("D", 0.3304, 0.7286, 0.6647, 0.899, num2);
      parte14.AdicionaPonto(parte14.PI.get_X("D"), -parte14.PI.get_Y("D"), -1, 0);
      parte14.AdicionaCurvaSequencia("Ce", 0.3353, 101.0 / 1000.0, 0.6696, 0.2714, num2);
      parte14.AdicionaPonto(parte14.PI.get_X("B"), -parte14.PI.get_Y("B"), -1, 0);
      parte14.AdicionaCurvaSequencia("A", 0.5419, 0.1724, 0.9673, 0.3049, num2);
      Molde molde5 = M;
      Molde molde6 = molde5;
      string _Nome6 = _Nome1;
      string _Nome7 = _Nome6;
      int _QualMedida5 = 1;
      int _QualMedida6 = _QualMedida5;
      double num136 = molde5.get_MedidaConferencia(_Nome6, _QualMedida5) + parte14.PerimetroEntrePontos("D1", "Ce");
      molde6.set_MedidaConferencia(_Nome7, _QualMedida6, num136);
      Molde molde7 = M;
      Molde molde8 = molde7;
      string _Nome8 = _Nome1;
      string _Nome9 = _Nome8;
      int _QualMedida7 = 2;
      int _QualMedida8 = _QualMedida7;
      double num137 = molde7.get_MedidaConferencia(_Nome8, _QualMedida7) + parte14.PerimetroEntrePontos("Cd", "D");
      molde8.set_MedidaConferencia(_Nome9, _QualMedida8, num137);
      Molde molde9 = M;
      Molde molde10 = molde9;
      string _Nome10 = "Cava Esquerda";
      string _Nome11 = _Nome10;
      int _QualMedida9 = 2;
      int _QualMedida10 = _QualMedida9;
      double num138 = molde9.get_MedidaConferencia(_Nome10, _QualMedida9) + parte14.PerimetroEntrePontos("D1", "Ce");
      molde10.set_MedidaConferencia(_Nome11, _QualMedida10, num138);
      Molde molde11 = M;
      Molde molde12 = molde11;
      string _Nome12 = "Cava Direita";
      string _Nome13 = _Nome12;
      int _QualMedida11 = 2;
      int _QualMedida12 = _QualMedida11;
      double num139 = molde11.get_MedidaConferencia(_Nome12, _QualMedida11) + parte14.PerimetroEntrePontos("Cd", "D");
      molde12.set_MedidaConferencia(_Nome13, _QualMedida12, num139);
      parte14.GiraParteNovo(System.Math.PI / 2.0, 0);
      double num140 = parte14.PerimetroEntrePontos("B", "Cd") / 3.0;
      int Index1 = parte14.AdicionaPontoLinha("X", parte14.PI.get_X("A"), parte14.AchaPontoImportante("B", 0));
      parte14.AdicionaPique(0.0, -0.5, Index1);
      parte14.PI.AdicionaPonto("A1", parte14.X[Index1], parte14.Y[Index1]);
      //if (Operators.CompareString(Left2, "Britanica", false) != 0)
      //  ;
      parte14.TrocaPontoZero(parte14.AchaPontoImportante("B", 0), false);
      parte14.AdicionaPique(0.0, 0.5, parte14.AchaPontoImportante("A", 0));
      parte14.Ampliacao(nMargemCostura);
      parte14.TransformaPiquesAmp();
      parte14.AdicionaPiqueAmp(0.3, 0.0, parte14.AdicionaPontoLinhaAmp("Y", parte14.PI.get_Y("Ce") + 2.0, checked(parte14.AchaPontoImportante("D1", 0) - 2)));
      double num141 = parte14.PerimetroEntrePontos("Cd", "D");
      double num142 = parte14.PerimetroEntrePontos("D1", "Ce");
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index2, 0, 0, true, false);
      M.Partes[ParteCopiada3].InverteCordenadas(false, true);
      Parte parte15 = M.Partes[ParteCopiada1];
      parte15.RespeitaXadrez = true;
      parte15.PermiteDesenho = false;
      parte15.Gabarito = false;
      int index22 = ParteCopiada3;
      Parte.Pontos pi9 = parte15.PI;
      pi9.AdicionaPonto("AL", M.Partes[index22].PI.get_X("A"), 0.0);
      pi9.AdicionaPonto("A", pi9.get_X("AL") - num82, 0.0);
      pi9.AdicionaPonto("Bd", pi9.get_X("A") + 2.0, -(num25 / 2.0 + num26));
      pi9.AdicionaPonto("Cd", pi9.get_X("AL") + (M.Partes[index22].PI.get_X("F") - M.Partes[index22].PI.get_X("A")), 1.0 - pi9.get_Y("AL") + (M.Partes[index22].PI.get_Y("F") - M.Partes[index22].PI.get_Y("A")));
      pi9.AdicionaPonto("Dd", pi9.get_X("Bd") + (pi9.get_X("Cd") - pi9.get_X("Bd")) * 0.6, -num25 / 2.0 + 0.5);
      //if (!flag1)
      //{
      //  if (itensModelos1.get_TemNaOpcaoSelecionada("Pregas", "Sem"))
      //    pi9.AtualizaPonto("Dd", 0.0, 1.0);
      //}
      //else if (ModeloNovo.get_TemNaOpcaoSelecionada("OpcaoPregas", "Sem"))
      //  pi9.AtualizaPonto("Dd", 0.0, 1.0);

      pi9.AdicionaPonto("Ed", pi9.get_X("AL") + (M.Partes[index22].PI.get_X("G") - M.Partes[index22].PI.get_X("A")), 1.0 - pi9.get_Y("AL") + (M.Partes[index22].PI.get_Y("G") - M.Partes[index22].PI.get_Y("A")));
      if (flag11)
        pi9.AtualizaPonto("Ed", 0.0, -num46);
      pi9.AdicionaPonto("Fd", pi9.get_X("AL") + (M.Partes[index22].PI.get_X("H") - M.Partes[index22].PI.get_X("A")), 1.0 - pi9.get_Y("AL") + (M.Partes[index22].PI.get_Y("H") - M.Partes[index22].PI.get_Y("A")));
      pi9.AdicionaPonto("H", pi9.get_X("AL") + (M.Partes[index22].PI.get_X("J") - M.Partes[index22].PI.get_X("A")) + num23 - num22, pi9.get_Y("AL") + (M.Partes[index22].PI.get_Y("J") - M.Partes[index22].PI.get_Y("A")));
      pi9.AtualizaPonto("Dd", -num59, -num58);
      pi9.AtualizaPonto("Cd", 0.0, num50 - num53);
      pi9.AtualizaPonto("Ed", 0.0, num52 - num54);
      pi9.AtualizaPonto("Fd", 0.0, num57 - num56);
      pi9.AtualizaPonto("Bd", 0.0, -num60);
      pi9.AtualizaPonto("Dd", 0.0, -num60);
      if (pi9.get_Y("Fd") < pi9.get_Y("Ed"))
        pi9.AdicionaPonto("Gd", pi9.get_X("AL") + (M.Partes[index22].PontosImportantes.get_X("I") - M.Partes[index22].PontosImportantes.get_X("A")), pi9.get_Y("Fd") - 0.25);
      else
        pi9.AdicionaPonto("Gd", pi9.get_X("AL") + (M.Partes[index22].PontosImportantes.get_X("I") - M.Partes[index22].PontosImportantes.get_X("A")), -(pi9.get_X("Ed") - (pi9.get_X("AL") + (M.Partes[index22].PI.get_X("I") - M.Partes[index22].PI.get_X("A")))) * (pi9.get_Y("Ed") - pi9.get_Y("Fd")) / (pi9.get_X("Ed") - pi9.get_X("Fd")) + pi9.get_Y("Ed"));
      if (!flag2)
      {
        pi9.AtualizaPonto("Ed", -Incremento_X, 0.0);
        pi9.AtualizaPonto("Fd", -Incremento_X, 0.0);
        pi9.AtualizaPonto("Gd", -Incremento_X, 0.0);
      }
      parte15.AdicionaPontoImportante("A", -1, 0);
      parte15.AdicionaCurvaSequencia("Bd", 0.0395, 0.3573, 0.3181, 436.0 / 625.0, num2);
      double MedidaPerimetro1 = num25 / 2.0 + num26 - nMargemCostura + num60;
      int index23 = parte15.AdicionaPontoPerimetro(0, MedidaPerimetro1);
      parte15.PI.AdicionaPonto("Bd1", parte15.X[index23], parte15.Y[index23]);
      parte15.PI.AdicionaPonto("Be1", parte15.PI.get_X("Bd1"), -parte15.PI.get_Y("Bd1"));
      int num143 = checked(parte15.QuantPontos - 1);
      int num144 = checked(index23 + 1);
      int num145 = num143;
      int num146 = num144;
      while (num146 <= num145)
      {
        parte15.ExcluePonto(checked(index23 + 1));
        checked { ++num146; }
      }
      parte15.AdicionaCurvaSequencia("Dd", 0.3785, 0.5647, 0.6179, 0.9032, num2);
      parte15.AdicionaCurvaSequencia("Cd", 0.558, 0.0706, 0.7769, 0.3011, num2);
      parte15.AdicionaCurvaSequencia("Ed", 0.2921, 0.3773, 0.7078, 566.0 / 625.0, num2);
      parte15.AdicionaCurvaSequencia("Fd", 0.4874, 0.0462, 0.6147, 0.8033, num2);
      parte15.AdicionaCurvaSequencia("Gd", 0.298, 0.4073, 0.589, 0.6613, num2);
      parte15.AdicionaCurvaSequencia("H", 0.695, 0.2302, 1.0695, 198.0 / 625.0, num2);
      Molde molde13 = M;
      Molde molde14 = molde13;
      string _Nome14 = "Cava Direita";
      string _Nome15 = _Nome14;
      int _QualMedida13 = 2;
      int _QualMedida14 = _QualMedida13;
      double num147 = molde13.get_MedidaConferencia(_Nome14, _QualMedida13) + parte15.PerimetroEntrePontos("Bd1", "Cd");
      molde14.set_MedidaConferencia(_Nome15, _QualMedida14, num147);
      M.Partes[ParteCopiada3].LimpaParte(false);
      M.Partes[ParteCopiada3].CopiaParte(M, index1, 0, 0, true, false);
      Parte parte16 = M.Partes[ParteCopiada2];
      parte16.RespeitaXadrez = true;
      parte16.PermiteDesenho = false;
      parte16.Gabarito = false;
      int index24 = ParteCopiada3;
      Parte.Pontos pi10 = parte16.PI;
      pi10.AdicionaPonto("AL", M.Partes[index1].PI.get_X("A"), 0.0);
      pi10.AdicionaPonto("A", pi10.get_X("AL") - num82, 0.0);
      pi10.AdicionaPonto("Be", pi10.get_X("A") + 2.0, -(num25 / 2.0 + num26));
      pi10.AdicionaPonto("Ce", pi10.get_X("AL") + (M.Partes[index24].PI.get_X("F") - M.Partes[index24].PI.get_X("A")), 1.0 - pi10.get_Y("AL") + (M.Partes[index24].PI.get_Y("F") - M.Partes[index24].PI.get_Y("A")));
      pi10.AdicionaPonto("De", pi10.get_X("Be") + (pi10.get_X("Ce") - pi10.get_X("Be")) * 0.6, -num25 / 2.0 + 0.5);
      //if (!flag1)
      //{
      //  if (itensModelos1.get_TemNaOpcaoSelecionada("Pregas", "Sem"))
      //    pi10.AtualizaPonto("De", 0.0, 1.0);
      //}
      //else if (ModeloNovo.get_TemNaOpcaoSelecionada("OpcaoPregas", "Sem"))
      //  pi10.AtualizaPonto("De", 0.0, 1.0);
      pi10.AdicionaPonto("Ee", pi10.get_X("AL") + (M.Partes[index24].PI.get_X("G") - M.Partes[index24].PI.get_X("A")), 1.0 - pi10.get_Y("AL") + (M.Partes[index24].PI.get_Y("G") - M.Partes[index24].PI.get_Y("A")));
      if (flag11)
        pi10.AtualizaPonto("Ee", 0.0, -num46);
      pi10.AdicionaPonto("Fe", pi10.get_X("AL") + (M.Partes[index24].PI.get_X("H") - M.Partes[index24].PI.get_X("A")), 1.0 - pi10.get_Y("AL") + (M.Partes[index24].PI.get_Y("H") - M.Partes[index24].PI.get_Y("A")));
      pi10.AdicionaPonto("H", pi10.get_X("AL") + (M.Partes[index24].PI.get_X("J") - M.Partes[index24].PI.get_X("A")) + num23 - num22, pi10.get_Y("AL") + (M.Partes[index24].PI.get_Y("J") - M.Partes[index24].PI.get_Y("A")));
      pi10.AtualizaPonto("De", -num59, -num58);
      pi10.AtualizaPonto("Ce", 0.0, num50 - num53);
      pi10.AtualizaPonto("Ee", 0.0, num52 - num54);
      pi10.AtualizaPonto("Fe", 0.0, num57 - num56);
      pi10.AtualizaPonto("Be", 0.0, -num60);
      pi10.AtualizaPonto("De", 0.0, -num60);
      if (pi10.get_Y("Fe") < pi10.get_Y("Ee"))
        pi10.AdicionaPonto("Ge", pi10.get_X("AL") + (M.Partes[index24].PontosImportantes.get_X("I") - M.Partes[index24].PontosImportantes.get_X("A")), pi10.get_Y("Fe") - 0.25);
      else
        pi10.AdicionaPonto("Ge", pi10.get_X("AL") + (M.Partes[index24].PontosImportantes.get_X("I") - M.Partes[index24].PontosImportantes.get_X("A")), -(pi10.get_X("Ee") - (pi10.get_X("AL") + (M.Partes[index24].PI.get_X("I") - M.Partes[index24].PI.get_X("A")))) * (pi10.get_Y("Ee") - pi10.get_Y("Fe")) / (pi10.get_X("Ee") - pi10.get_X("Fe")) + pi10.get_Y("Ee"));
      if (!flag2)
      {
        pi10.AtualizaPonto("Ee", -Incremento_X, 0.0);
        pi10.AtualizaPonto("Fe", -Incremento_X, 0.0);
        pi10.AtualizaPonto("Ge", -Incremento_X, 0.0);
      }
      parte16.AdicionaPontoImportante("A", -1, 0);
      parte16.AdicionaCurvaSequencia("Be", 0.0395, 0.3573, 0.3181, 436.0 / 625.0, num2);
      double MedidaPerimetro2 = num25 / 2.0 + num26 - nMargemCostura + num60;
      int index25 = parte16.AdicionaPontoPerimetro(0, MedidaPerimetro2);
      parte16.PI.AdicionaPonto("Be1", parte16.X[index25], parte16.Y[index25]);
      parte16.PI.AdicionaPonto("Bd1", parte16.PI.get_X("Be1"), -parte16.PI.get_Y("Be1"));
      int num148 = checked(parte16.QuantPontos - 1);
      int num149 = checked(index25 + 1);
      int num150 = num148;
      int num151 = num149;
      while (num151 <= num150)
      {
        parte16.ExcluePonto(checked(index25 + 1));
        checked { ++num151; }
      }
      parte16.AdicionaCurvaSequencia("De", 0.3785, 0.5647, 0.6179, 0.9032, num2);
      parte16.AdicionaCurvaSequencia("Ce", 0.558, 0.0706, 0.7769, 0.3011, num2);
      parte16.AdicionaCurvaSequencia("Ee", 0.2921, 0.3773, 0.7078, 566.0 / 625.0, num2);
      parte16.AdicionaCurvaSequencia("Fe", 0.4874, 0.0462, 0.6147, 0.8033, num2);
      parte16.AdicionaCurvaSequencia("Ge", 0.298, 0.4073, 0.589, 0.6613, num2);
      parte16.AdicionaCurvaSequencia("H", 0.695, 0.2302, 1.0695, 198.0 / 625.0, num2);
      Molde molde15 = M;
      Molde molde16 = molde15;
      string _Nome16 = "Cava Esquerda";
      string _Nome17 = _Nome16;
      int _QualMedida15 = 2;
      int _QualMedida16 = _QualMedida15;
      double num152 = molde15.get_MedidaConferencia(_Nome16, _QualMedida15) + parte16.PerimetroEntrePontos("Be1", "Ce");
      molde16.set_MedidaConferencia(_Nome17, _QualMedida16, num152);
      parte16.InverteCordenadas(false, true);
      Parte parte17 = M.Partes[Parte1];
      parte17.RespeitaXadrez = true;
      parte17.PermiteDesenho = true;
      parte17.Gabarito = false;
      parte17.CopiaParte(M, ParteCopiada1, 0, 0, true, false);
      parte17.CopiaParte(M, ParteCopiada2, 0, 0, true, false);
      Molde molde17 = M;
      Molde molde18 = molde17;
      string _Nome18 = _Nome1;
      string _Nome19 = _Nome18;
      int _QualMedida17 = 1;
      int _QualMedida18 = _QualMedida17;
      double num153 = molde17.get_MedidaConferencia(_Nome18, _QualMedida17) + parte17.PerimetroEntrePontos("Ce", "Be1");
      molde18.set_MedidaConferencia(_Nome19, _QualMedida18, num153);
      Molde molde19 = M;
      Molde molde20 = molde19;
      string _Nome20 = _Nome1;
      string _Nome21 = _Nome20;
      int _QualMedida19 = 2;
      int _QualMedida20 = _QualMedida19;
      double num154 = molde19.get_MedidaConferencia(_Nome20, _QualMedida19) + parte17.PerimetroEntrePontos("Bd1", "Cd");
      molde20.set_MedidaConferencia(_Nome21, _QualMedida20, num154);
      parte17.RespeitaXadrez = true;
      parte17.TrocaPontoZero(parte17.AchaPontoImportante("Cd", 0), false);
      int index26 = parte17.AdicionaPontoPerimetro(0, 3.0);
      parte17.PI.AdicionaPonto("P1", parte17.X[index26], parte17.Y[index26]);
      parte17.PerimetroEntrePontos("P1", "Fd");
      parte17.AdicionaPique(0.5, 0.0, parte17.AchaPontoImportante("A", 0));
      if (Operators.CompareString(Left2, "Britanica", false) == 0)
      {
        parte17.AdicionaPique(0.5, 0.0, parte17.AdicionaPontoPerimetro(parte17.AchaPontoImportante("A", 0), num25 / 2.0 - nMargemCostura - 8.5));
        parte17.AdicionaPique(0.5, 0.0, parte17.AdicionaPontoPerimetro(parte17.AchaPontoImportante("A", 0), num25 / 2.0 - nMargemCostura - 8.5 + num26));
        parte17.AdicionaPique(0.5, 0.0, parte17.AdicionaPontoPerimetro(parte17.AchaPontoImportante("Be1", 0), parte17.PerimetroEntrePontos("Be1", "A") - (num25 / 2.0 - nMargemCostura - 8.5 + num26)));
        parte17.AdicionaPique(0.5, 0.0, parte17.AdicionaPontoPerimetro(parte17.AchaPontoImportante("Be1", 0), parte17.PerimetroEntrePontos("Be1", "A") - (num25 / 2.0 - nMargemCostura - 8.5)));
      }
      parte17.Ampliacao(nMargemCostura);
      if (!flag2)
      {
        parte17.AdicionaPontoAmp(parte17.PontosImportantes.get_X("Ee") - num42, (parte17.PontosImportantes.get_Y("Ee") + parte17.PontosImportantes.get_Y("Al")) / 2.0, -1, 2);
        parte17.AdicionaPontoRelativoAmp(-num43 * 0.425, 0.0, -1, 2);
        parte17.AdicionaPontoRelativoAmp(num43 * 0.425, -num44 / 2.0, -1, 1);
        parte17.AdicionaPontoRelativoAmp(num43 * 0.575, num44 / 2.0, -1, 1);
        parte17.AdicionaPontoRelativoAmp(-num43 * 0.575, num44 / 2.0, -1, 1);
        parte17.AdicionaPontoRelativoAmp(-num43 * 0.425, -num44 / 2.0, -1, 1);
        parte17.AdicionaPontoAmp(parte17.PontosImportantes.get_X("Ed") - num42, (parte17.PontosImportantes.get_Y("Ed") + parte17.PontosImportantes.get_Y("Al")) / 2.0, -1, 2);
        parte17.AdicionaPontoRelativoAmp(-num43 * 0.425, 0.0, -1, 2);
        parte17.AdicionaPontoRelativoAmp(num43 * 0.425, -num44 / 2.0, -1, 1);
        parte17.AdicionaPontoRelativoAmp(num43 * 0.575, num44 / 2.0, -1, 1);
        parte17.AdicionaPontoRelativoAmp(-num43 * 0.575, num44 / 2.0, -1, 1);
        parte17.AdicionaPontoRelativoAmp(-num43 * 0.425, -num44 / 2.0, -1, 1);
      }
      else if (flag11)
      {
        double ValorX1 = parte17.PontosImportantes.get_X("Ee");
        double num155 = (parte17.PontosImportantes.get_Y("Ee") + parte17.PontosImportantes.get_Y("Al")) / 2.0 - 2.0;
        parte17.AdicionaPontoAmp(ValorX1, num155, -1, 2);
        int index27 = parte17.AdicionaPontoLinhaAmp("Y", num155, 0);
        int index28 = parte17.AdicionaPontoLinhaAmp("Y", num155, checked(index27 + 3));
        parte17.AdicionaPontoAmp(ValorX1, num155 + num46 / 2.0, -1, 2);
        parte17.AdicionaPontoAmp(parte17.AmpX[index27], parte17.AmpY[index27], -1, 1);
        parte17.AdicionaPontoAmp(ValorX1, num155 - num46 / 2.0, -1, 1);
        parte17.AdicionaPontoAmp(parte17.AmpX[index28], parte17.AmpY[index28], -1, 1);
        parte17.AdicionaPontoAmp(ValorX1, num155 + num46 / 2.0, -1, 1);
        double ValorX2 = parte17.PontosImportantes.get_X("Ed");
        double num156 = (parte17.PontosImportantes.get_Y("Ed") + parte17.PontosImportantes.get_Y("Al")) / 2.0 + 2.0;
        parte17.AdicionaPontoAmp(ValorX2, num156, -1, 2);
        int index29 = parte17.AdicionaPontoLinhaAmp("Y", num156, 0);
        int index30 = parte17.AdicionaPontoLinhaAmp("Y", num156, checked(index29 + 3));
        parte17.AdicionaPontoAmp(ValorX2, num156 + num46 / 2.0, -1, 2);
        parte17.AdicionaPontoAmp(parte17.AmpX[index29], parte17.AmpY[index29], -1, 1);
        parte17.AdicionaPontoAmp(ValorX2, num156 - num46 / 2.0, -1, 1);
        parte17.AdicionaPontoAmp(parte17.AmpX[index30], parte17.AmpY[index30], -1, 1);
        parte17.AdicionaPontoAmp(ValorX2, num156 + num46 / 2.0, -1, 1);
      }
      parte17.TransformaPiquesAmp();
      parte17.AdicionaPiqueAmp(0.0, -0.3, parte17.AdicionaPontoLinhaAmp("X", parte17.PI.get_X("Ce") - 3.0, checked(parte17.AchaPontoImportante("Ce", 0) - 3)));
      double num157 = parte17.PerimetroEntrePontos("Ce", "Be1");
      double num158 = parte17.PerimetroEntrePontos(parte17.AchaPontoImportante("Bd1", 0), checked(parte17.QuantPontos - 1), false);
      M.set_MedidaConferencia("med", 2, parte17.PerimetroEntrePontos("P1", "Fd"));
      M.set_MedidaConferencia("med1", 2, parte17.PerimetroEntrePontos("Cd", "Fd"));
      Parte parte18 = M.Partes[Parte12];
      parte18.PermiteDesenho = false;
      parte18.RespeitaXadrez = true;
      int num159 = 0;
      int num160 = checked(M.Partes[Parte1].QuantPontos - 1);
      int index31 = num159;
      while (index31 <= num160)
      {
        parte18.AdicionaPonto(M.Partes[Parte1].X[index31], M.Partes[Parte1].Y[index31], -1, M.Partes[Parte1].Amplia[index31]);
        checked { ++index31; }
      }
      int num161 = 0;
      int num162 = checked(M.Partes[Parte1].QuantPontosAmp - 1);
      int index32 = num161;
      while (index32 <= num162)
      {
        parte18.AdicionaPontoAmp(M.Partes[Parte1].AmpX[index32], M.Partes[Parte1].AmpY[index32], -1, M.Partes[Parte1].Risca[index32]);
        checked { ++index32; }
      }
      int num163 = 0;
      int num164 = checked(M.Partes[Parte1].PI.QPontos - 1);
      int index33 = num163;
      while (index33 <= num164)
      {
        parte18.PI.AdicionaPonto(M.Partes[Parte1].PI.Item[index33].Nome, M.Partes[Parte1].PI.Item[index33].X, M.Partes[Parte1].PI.Item[index33].Y);
        checked { ++index33; }
      }
      int index34 = parte18.AdicionaPontoLinhaAmp("X", parte18.AmpX[0], 2);
      parte18.PI.AdicionaPonto("base", parte18.AmpX[index34], parte18.AmpY[index34]);
      parte18.CortaNoMeio();
      int num165 = parte18.AchaPontoCordenadas(parte18.PI.get_X("Ce"), parte18.PI.get_Y("Ce"), 0);
      int num166 = 0;
      int num167 = num165;
      int index35 = num166;
      while (index35 <= num167)
      {
        parte18.AdicionaPonto(parte18.X[index35], parte18.Y[index35], -1, parte18.Amplia[index35]);
        checked { ++index35; }
      }
      int num168 = 0;
      int num169 = checked(num165 - 1);
      int num170 = num168;
      while (num170 <= num169)
      {
        parte18.ExcluePonto(0);
        checked { ++num170; }
      }
      int num171 = parte18.AchaPontoAmpCordenadas(parte18.PI.get_X("base"), parte18.PI.get_Y("base"), 0);
      int num172 = 0;
      int num173 = num171;
      int index36 = num172;
      while (index36 <= num173)
      {
        parte18.AdicionaPontoAmp(parte18.AmpX[index36], parte18.AmpY[index36], -1, parte18.Risca[index36]);
        checked { ++index36; }
      }
      int num174 = 0;
      int num175 = checked(num171 - 1);
      int num176 = num174;
      while (num176 <= num175)
      {
        parte18.ExcluePontoAmp(0);
        checked { ++num176; }
      }
      parte18.RetiraPontosIguais();
      parte18.RetiraPontosIguaisAmp();
      parte18.Area = M.Partes[Parte1].Area;
      Parte parte19 = M.Partes[index1];
      int index37 = parte19.AdicionaPontoPerimetro(parte19.AchaPontoImportante("F", 0), parte19.PerimetroEntrePontos("F", "H") - M.get_MedidaConferencia("med", 2));
      parte19.PI.AdicionaPonto("P1", parte19.X[index37], parte19.Y[index37]);
      parte19.Fecha();
      parte19.TrocaPontoZero(parte19.AchaPontoImportante("F", 0), false);
      parte19.Ampliacao(nMargemCostura);
      int num177 = parte19.AchaPontoImportante("M2", 0);
      int num178 = parte19.AchaPontoImportante("M1", 0);
      int num179 = checked(num177 + 1);
      int num180 = checked(num178 - 1);
      int num181 = num179;
      while (num181 <= num180)
      {
        parte19.ExcluePonto(checked(num177 + 1));
        checked { ++num181; }
      }
      int index38 = parte19.AdicionaPontoLinhaAmp("Y", parte19.PI.get_Y("M1"), 0);
      int num182 = parte19.AdicionaPontoLinhaAmp("Y", parte19.PI.get_Y("M1"), checked(index38 + 3));
      int num183 = checked(index38 + 1);
      int num184 = checked(num182 - 1);
      int num185 = num183;
      while (num185 <= num184)
      {
        parte19.ExcluePontoAmp(checked(index38 + 1));
        checked { ++num185; }
      }
      parte19.AdicionaPiqueAmp(-0.5, 0.0, index38);
      //if (str2.Equals("Coberta"))
      //  parte19.AdicionaPontoRelativoAmp(0.0, 13.0, checked(index38 + 3), 0);
      //else
      //  parte19.AdicionaPontoRelativoAmp(0.0, 8.0, checked(index38 + 3), 0);
      int index39 = parte19.AdicionaPontoAmp(parte19.AmpX[checked(index38 + 4)], parte19.AmpY[checked(index38 + 3)], checked(index38 + 4), 0);
      parte19.AdicionaPontoAmp(parte19.AmpX[checked(index38 + 5)], parte19.AmpY[checked(index38 + 5)], checked(index38 + 5), 0);
      int PontoInicial1 = checked(index38 + 4);
      //int ContI = !str2.Equals("Coberta") ? parte19.AdicionaPontoLinhaAmp("Y", parte19.AmpY[PontoInicial1] - 6.0, PontoInicial1) : parte19.AdicionaPontoLinhaAmp("Y", parte19.AmpY[PontoInicial1] - 11.0, PontoInicial1);
      int ContI = true ? parte19.AdicionaPontoLinhaAmp("Y", parte19.AmpY[PontoInicial1] - 6.0, PontoInicial1) : parte19.AdicionaPontoLinhaAmp("Y", parte19.AmpY[PontoInicial1] - 11.0, PontoInicial1);
      double[] ampX1 = parte19.AmpX;
      double[] numArray1 = ampX1;
      int index40 = index39;
      int index41 = index40;
      double num186 = ampX1[index40] - 0.75;
      numArray1[index41] = num186;
      parte19.AdicionaPontoAmp(parte19.AmpX[index39], parte19.AmpY[ContI], ContI, 0);
      parte19.AdicionaPiqueAmp(-0.5, 0.0, parte19.AdicionaPontoLinhaAmp("Y", parte19.AmpY[index38] + 2.0, index38));
      parte19.ExcluePontoAmp(checked(index38 + 2));
      parte19.ExcluePontoAmp(checked(index38 + 1));
      if (!flag2)
      {
        parte19.AdicionaPiqueAmp(0.0, 0.5, parte19.AdicionaPontoPerimetroAmp(0, 4.0 - Incremento_X / 2.0));
        parte19.AdicionaPiqueAmp(0.0, 0.5, parte19.AdicionaPontoPerimetroAmp(0, 4.0 + Incremento_X / 2.0));
        int index27 = parte19.get_AchaPiqueAmp(1);
        int index28 = parte19.get_AchaPiqueAmp(2);
        double[] numArray2 = new double[3]
        {
          (parte19.AmpX[index28] + parte19.AmpX[index27]) / 2.0,
          parte19.AmpY[index28] + num37,
          0.0
        };
        parte19.AmpX[checked(index27 + 1)] = numArray2[0];
        parte19.AmpY[checked(index27 + 1)] = numArray2[1];
        parte19.AmpX[checked(index28 + 1)] = numArray2[0];
        parte19.AmpY[checked(index28 + 1)] = numArray2[1];
        parte19.Risca[checked(index27 + 1)] = 1;
        parte19.Risca[checked(index28 + 1)] = 1;
        parte19.AdicionaPontoAmp(parte19.PontosImportantes.get_X("G") - num39, (parte19.PontosImportantes.get_Y("G") + parte19.PontosImportantes.get_Y("A")) / 2.0, -1, 2);
        parte19.AdicionaPontoRelativoAmp(-num40 / 3.0, 0.0, -1, 2);
        parte19.AdicionaPontoRelativoAmp(num40 / 3.0, -num41 / 2.0, -1, 1);
        parte19.AdicionaPontoRelativoAmp(num40 * 2.0 / 3.0, num41 / 2.0, -1, 1);
        parte19.AdicionaPontoRelativoAmp(-num40 * 2.0 / 3.0, num41 / 2.0, -1, 1);
        parte19.AdicionaPontoRelativoAmp(-num40 / 3.0, -num41 / 2.0, -1, 1);
      }
      parte19.RetiraPontosIguaisAmp();
      parte19.TransformaPiquesAmp();
      parte19.AdicionaPiqueAmp(0.0, 0.3, parte19.AdicionaPontoLinhaAmp("X", parte19.PI.get_X("C") + 3.0, checked(parte19.AchaPontoAmpliado(parte19.AchaPontoImportante("E", 0), nMargemCostura) - 10)));
      Parte parte20 = M.Partes[index2];
      int index42 = parte20.AdicionaPontoPerimetro(parte20.AchaPontoImportante("H", 0), M.get_MedidaConferencia("med", 2));
      parte20.PI.AdicionaPonto("P1", parte20.X[index42], parte20.Y[index42]);
      parte20.Fecha();
      parte20.TrocaPontoZero(parte20.AchaPontoImportante("F", 0), false);
      parte20.Ampliacao(nMargemCostura);
      int num187 = parte20.AchaPontoImportante("M1", 0);
      int num188 = parte20.AchaPontoImportante("M2", 0);
      int num189 = checked(num187 + 1);
      int num190 = checked(num188 - 1);
      int num191 = num189;
      while (num191 <= num190)
      {
        parte20.ExcluePonto(checked(num187 + 1));
        checked { ++num191; }
      }
      int index43 = parte20.AdicionaPontoLinhaAmp("Y", parte20.PI.get_Y("M1"), 0);
      int num192 = parte20.AdicionaPontoLinhaAmp("Y", parte20.PI.get_Y("M1"), checked(index43 + 3));
      int num193 = checked(index43 + 1);
      int num194 = checked(num192 - 1);
      int num195 = num193;
      while (num195 <= num194)
      {
        parte20.ExcluePontoAmp(checked(index43 + 1));
        checked { ++num195; }
      }
      parte20.AdicionaPiqueAmp(0.5, 0.0, index43);
      int index44 = parte20.AdicionaPontoRelativoAmp(0.0, -8.0, checked(index43 + 3), 0);
      parte20.AdicionaPontoAmp(parte20.AmpX[checked(index43 + 4)], parte20.AmpY[checked(index43 + 3)], checked(index43 + 4), 0);
      parte20.AdicionaPontoAmp(parte20.AmpX[checked(index43 + 5)], parte20.AmpY[checked(index43 + 5)], checked(index43 + 5), 0);
      parte20.PI.AdicionaPonto("pp1", parte20.AmpX[index44], parte20.AmpY[index44]);
      int PontoInicial2 = checked(index43 + 4);
      parte20.AdicionaPiqueAmp(-0.5, 0.0, parte20.AdicionaPontoLinhaAmp("Y", parte20.AmpY[index43] - 2.0, PontoInicial2));
      int index45 = parte20.AdicionaPontoLinhaAmp("Y", parte20.AmpY[index43] - 2.0, index43);
      parte20.PI.AdicionaPonto("pp2", parte20.AmpX[index45], parte20.AmpY[index45]);
      double[] ampX2 = parte20.AmpX;
      double[] numArray3 = ampX2;
      int index46 = checked(index44 + 1);
      int index47 = index46;
      double num196 = ampX2[index46] - 0.75;
      numArray3[index47] = num196;
      parte20.AdicionaPontoAmp(parte20.AmpX[index45] - 0.75, parte20.AmpY[index45], checked(index45 + 1), 0);
      parte20.ExcluePontoAmp(checked(index43 + 2));
      parte20.ExcluePontoAmp(checked(index43 + 1));
      if (!flag2)
      {
        double num155 = parte20.PerimetroEntrePontos(0, checked(parte20.QuantPontosAmp - 1), true);
        parte20.AdicionaPiqueAmp(0.0, -0.5, parte20.AdicionaPontoPerimetroAmp(0, num155 - 4.0 + Incremento_X / 2.0));
        parte20.AdicionaPiqueAmp(0.0, -0.5, parte20.AdicionaPontoPerimetroAmp(0, num155 - 4.0 - Incremento_X / 2.0));
        int index27 = parte20.get_AchaPiqueAmp(parte20.QuantPiquesAmp);
        int index28 = parte20.get_AchaPiqueAmp(checked(parte20.QuantPiquesAmp - 1));
        double[] numArray2 = new double[3]
        {
          (parte20.AmpX[index28] + parte20.AmpX[index27]) / 2.0,
          parte20.AmpY[index28] - num37,
          0.0
        };
        parte20.AmpX[checked(index27 + 1)] = numArray2[0];
        parte20.AmpY[checked(index27 + 1)] = numArray2[1];
        parte20.AmpX[checked(index28 + 1)] = numArray2[0];
        parte20.AmpY[checked(index28 + 1)] = numArray2[1];
        parte20.Risca[checked(index27 + 1)] = 1;
        parte20.Risca[checked(index28 + 1)] = 1;
        parte20.AdicionaPontoAmp(parte20.PontosImportantes.get_X("G") - num39, (parte20.PontosImportantes.get_Y("G") + parte20.PontosImportantes.get_Y("A")) / 2.0, -1, 2);
        parte20.AdicionaPontoRelativoAmp(-num40 / 3.0, 0.0, -1, 2);
        parte20.AdicionaPontoRelativoAmp(num40 / 3.0, -num41 / 2.0, -1, 1);
        parte20.AdicionaPontoRelativoAmp(num40 * 2.0 / 3.0, num41 / 2.0, -1, 1);
        parte20.AdicionaPontoRelativoAmp(-num40 * 2.0 / 3.0, num41 / 2.0, -1, 1);
        parte20.AdicionaPontoRelativoAmp(-num40 / 3.0, -num41 / 2.0, -1, 1);
      }
      parte20.RetiraPontosIguaisAmp();
      parte20.TransformaPiquesAmp();
      double val2_2 = M.get_MedidaConferencia("Cava Esquerda", 2);
      double val1_2 = M.get_MedidaConferencia("Cava Direita", 2);
      double num197 = System.Math.Max(val1_2, val2_2);
      Parte parte21 = M.Partes[index11];
      parte21.PermiteDesenho = true;
      parte21.Gabarito = false;
      if (!flag12)
      {
        Parte.Pontos pi11 = parte21.PI;
        pi11.AdicionaPonto("A", nMargemCostura, 0.0);
        pi11.AdicionaPonto("B", 15.42, nMargemCostura - 26.3);
        pi11.AdicionaPonto("C", pi11.get_X("A") + (pi11.get_X("B") - pi11.get_X("A")) * 0.3854, pi11.get_Y("A") + (pi11.get_Y("B") - pi11.get_Y("A")) * 0.5141);
        parte21.AdicionaPontoImportante("A", -1, 0);
        parte21.AdicionaCurvaSequencia("C", 0.0476, 57.0 / 80.0, 0.5523, 0.7677, num2);
        parte21.AdicionaCurvaSequencia("B", 0.4431, 0.3416, 0.9041, 53.0 / 80.0, num2);
        if (val2_2 / 2.0 < 29.9)
        {
          parte21.AdicionaPique(1.0, 0.0, parte21.AdicionaPontoPerimetro(0, 30.0 - val2_2 / 2.0));
        }
        else
        {
          parte21.AdicionaCurva(parte21.X[0] - 0.25, parte21.Y[0] + (val2_2 / 2.0 - 29.8), parte21.X[0], parte21.Y[0], 0.45, 0.45, 0.45, 0.55, 0, num2, false, 1.0);
          parte21.AdicionaPique(1.0, 0.0, parte21.AdicionaPontoPerimetro(0, parte21.TamanhoPerimetro(0, 0) - val2_2 / 2.0));
        }
        int index27 = index3;
        M.Partes[index27].PI.AdicionaPonto("B", 0.0, 0.0);
        M.Partes[index27].PI.AdicionaPonto("C", parte21.PI.get_X("B") - parte21.X[parte21.get_AchaPique(1)], parte21.PI.get_Y("B") - parte21.Y[parte21.get_AchaPique(1)]);
        M.Partes[index27].PI.AdicionaPonto("A", M.Partes[index27].PI.get_X("C"), -M.Partes[index27].PI.get_Y("C"));
        parte21.LimpaParte(false);
        Parte.Pontos pi12 = parte21.PI;
        pi12.AdicionaPonto("A", nMargemCostura, 0.0);
        pi12.AdicionaPonto("B", 15.42, nMargemCostura - 26.3);
        pi12.AdicionaPonto("C", pi12.get_X("A") + (pi12.get_X("B") - pi12.get_X("A")) * 0.3854, pi12.get_Y("A") + (pi12.get_Y("B") - pi12.get_Y("A")) * 0.5141);
        parte21.AdicionaPontoImportante("A", -1, 0);
        parte21.AdicionaCurvaSequencia("C", 0.0476, 57.0 / 80.0, 0.5523, 0.7677, num2);
        parte21.AdicionaCurvaSequencia("B", 0.4431, 0.3416, 0.9041, 53.0 / 80.0, num2);
        if (val1_2 / 2.0 < 29.9)
        {
          parte21.AdicionaPique(1.0, 0.0, parte21.AdicionaPontoPerimetro(0, 30.0 - val1_2 / 2.0));
        }
        else
        {
          parte21.AdicionaCurva(parte21.X[0] - 0.25, parte21.Y[0] + (val1_2 / 2.0 - 29.8), parte21.X[0], parte21.Y[0], 0.45, 0.45, 0.45, 0.55, 0, num2, false, 1.0);
          parte21.AdicionaPique(1.0, 0.0, parte21.AdicionaPontoPerimetro(0, parte21.TamanhoPerimetro(0, 0) - val1_2 / 2.0));
        }
        int index28 = Parte2;
        M.Partes[index28].PI.AdicionaPonto("B", 0.0, 0.0);
        M.Partes[index28].PI.AdicionaPonto("C", parte21.PI.get_X("B") - parte21.X[parte21.get_AchaPique(1)], parte21.PI.get_Y("B") - parte21.Y[parte21.get_AchaPique(1)]);
        M.Partes[index28].PI.AdicionaPonto("A", M.Partes[index28].PI.get_X("C"), -M.Partes[index28].PI.get_Y("C"));
      }
      else
      {
        Parte.Pontos pi11 = parte21.PI;
        pi11.AdicionaPonto("A", nMargemCostura, 0.0);
        pi11.AdicionaPonto("B", 15.42, nMargemCostura - 26.3);
        pi11.AdicionaPonto("C", pi11.get_X("A") + (pi11.get_X("B") - pi11.get_X("A")) * 0.3854, pi11.get_Y("A") + (pi11.get_Y("B") - pi11.get_Y("A")) * 0.5141);
        parte21.AdicionaPontoImportante("A", -1, 0);
        parte21.AdicionaCurvaSequencia("C", 0.0476, 57.0 / 80.0, 0.5523, 0.7677, num2);
        parte21.AdicionaCurvaSequencia("B", 0.4431, 0.3416, 0.9041, 53.0 / 80.0, num2);
        if (num197 / 2.0 < 29.9)
        {
          parte21.AdicionaPique(1.0, 0.0, parte21.AdicionaPontoPerimetro(0, 30.0 - num197 / 2.0));
        }
        else
        {
          parte21.AdicionaCurva(parte21.X[0] - 0.25, parte21.Y[0] + (num197 / 2.0 - 29.8), parte21.X[0], parte21.Y[0], 0.45, 0.45, 0.45, 0.55, 0, num2, false, 1.0);
          parte21.AdicionaPique(1.0, 0.0, parte21.AdicionaPontoPerimetro(0, parte21.TamanhoPerimetro(0, 0) - num197 / 2.0));
        }
        int index27 = index3;
        M.Partes[index27].PI.AdicionaPonto("B", 0.0, 0.0);
        M.Partes[index27].PI.AdicionaPonto("C", parte21.PI.get_X("B") - parte21.X[parte21.get_AchaPique(1)], parte21.PI.get_Y("B") - parte21.Y[parte21.get_AchaPique(1)]);
        M.Partes[index27].PI.AdicionaPonto("A", M.Partes[index27].PI.get_X("C"), -M.Partes[index27].PI.get_Y("C"));
      }
      double num198 = System.Math.Min(val1_1, val2_1);
      double num199 = num32;
      double num200 = num32;
      double num201 = num32;
      Parte parte22 = M.Partes[index3];
      parte22.RespeitaXadrez = true;
      parte22.PermiteDesenho = true;
      parte22.Gabarito = false;
      Parte.Pontos pi13 = parte22.PI;
      pi13.AdicionaPonto("CC1", pi13.get_X("B") + (pi13.get_X("C") - pi13.get_X("B")) * 0.275, pi13.get_Y("B") + (pi13.get_Y("C") - pi13.get_Y("B")) * (261.0 / 625.0));
      pi13.AdicionaPonto("CC2", pi13.get_X("B") + (pi13.get_X("C") - pi13.get_X("B")) * 0.7935, pi13.get_Y("B") + (pi13.get_Y("C") - pi13.get_Y("B")) * 0.7644);
      pi13.AdicionaPonto("CF1", pi13.get_X("B") + (pi13.get_X("A") - pi13.get_X("B")) * 0.7112, pi13.get_Y("B") + (pi13.get_Y("A") - pi13.get_Y("B")) * 0.6613);
      pi13.AdicionaPonto("CF2", pi13.get_X("B") + (pi13.get_X("A") - pi13.get_X("B")) * 0.1097, pi13.get_Y("B") + (pi13.get_Y("A") - pi13.get_Y("B")) * (162.0 / 625.0));
      pi13.AdicionaPonto("F", pi13.get_X("B") + num31 - ValorRelativoY + nMargemCostura, pi13.get_Y("B") - (val2_1 + num200 + num33 * 4.0) / 2.0);
      pi13.AdicionaPontoRelativo("F1", "F", 0.75, 0.0);
      pi13.AdicionaPonto("G", pi13.get_X("F"), pi13.get_Y("B"));
      pi13.AdicionaPonto("D", pi13.get_X("C") + (pi13.get_X("F") - pi13.get_X("C")) * 0.2411, pi13.get_Y("C") + (pi13.get_Y("B") - ((num198 + num201) / 2.0 + 1.0) - pi13.get_Y("C")) * 0.4312);
      pi13.AdicionaPonto("E", pi13.get_X("C") + (pi13.get_X("F") - pi13.get_X("C")) * 0.605, pi13.get_Y("C") + (pi13.get_Y("B") - ((num198 + num201) / 2.0 + 1.0) - pi13.get_Y("C")) * 0.7617);
      pi13.AtualizaPonto("D", 0.0, -num21);
      pi13.AtualizaPonto("E", 0.0, -num21 * 0.75);
      parte22.AdicionaPontoImportante("A", -1, 0);
      parte22.AdicionaCurvaSequencia("CF1", 0.2063, 0.4806, 0.619, 0.7467, num2);
      parte22.AdicionaCurvaSequencia("CF2", 0.3197, 0.3718, 0.7165, 0.6195, num2);
      parte22.AdicionaCurvaSequencia("B", 0.7917, 0.2778, 0.9845, 0.4838, num2);
      parte22.AdicionaCurvaSequencia("CC1", 0.0, 0.5802, 0.5161, 0.7299, num2);
      parte22.AdicionaCurvaSequencia("CC2", 0.3561, 0.3478, 0.6606, 0.6341, num2);
      parte22.AdicionaCurvaSequencia("C", 0.5311, 0.3163, 0.8827, 0.5845, num2);
      double num202 = parte22.PerimetroEntrePontos(Conversions.ToString(parte22.AchaPontoImportante("A", 0)), Conversions.ToString(parte22.AchaPontoImportante("C", 0)));
      if (flag12)
        val2_2 = num197;
      if (num202 > val2_2 + num29)
      {
        double MedidaPerimetro3 = (val2_2 + num29) / 2.0;
        int num155 = parte22.AdicionaPontoPerimetro(0, MedidaPerimetro3);
        int num156 = parte22.AdicionaPontoPerimetro(0, num202 - MedidaPerimetro3);
        int num203 = checked(parte22.QuantPontos - 1);
        int num204 = checked(num156 + 1);
        int num205 = num203;
        int num206 = num204;
        while (num206 <= num205)
        {
          parte22.ExcluePonto(checked(num156 + 1));
          checked { ++num206; }
        }
        int num207 = 0;
        int num208 = checked(num155 - 1);
        int num209 = num207;
        while (num209 <= num208)
        {
          parte22.ExcluePonto(0);
          checked { ++num209; }
        }
        int index27 = checked((int)System.Math.Round(parte22.PI.get_Indice("A")));
        parte22.PI.Item[index27].X = parte22.X[0];
        parte22.PI.Item[index27].Y = parte22.Y[0];
        int index28 = checked((int)System.Math.Round(parte22.PI.get_Indice("C")));
        parte22.PI.Item[index28].X = parte22.X[checked(parte22.QuantPontos - 1)];
        parte22.PI.Item[index28].Y = parte22.Y[checked(parte22.QuantPontos - 1)];
      }
      //if (!flag1)
      //{
      //  itensModelos1.set_MedidaCorpo("Peri_Cava_Esq", val2_2);
      //  itensModelos1.set_MedidaMolde("Peri_Cava_Esq", num202);
      //}
      //else
      //{
      //  ModeloNovo.set_Medida("Peri_Cava_Esq", val2_2);
      //  ModeloNovo.set_Medida("Confere_Cava_Esq", num202);
      //}

      double Peri_Cava_Esq = val2_2;
      double Confere_Cava_Esq = num202;

      M.set_MedidaConferencia("Cabeça Esquerda", 2, parte22.PerimetroEntrePontos("A", "C"));
      M.set_MedidaConferencia("Perimetro Cava Esquerda", 1, num202);
      M.set_MedidaConferencia("Perimetro Cava Esquerda", 2, val2_2);
      M.set_MedidaConferencia("Perimetro Cava Direita", 1, num202);
      M.set_MedidaConferencia("Perimetro Cava Direita", 2, val2_2);
      parte22.AdicionaCurvaSequencia("D", 0.3251, 0.4639, 0.6707, 301.0 / 400.0, num2);
      parte22.AdicionaCurvaSequencia("E", 0.323, 0.3842, 0.667, 0.6973, num2);
      parte22.AdicionaCurvaSequencia("F1", 0.3299, 0.4189, 0.6547, 0.6845, num2);
      parte22.AdicionaPonto(parte22.X[checked(parte22.QuantPontos - 1)] - (parte22.X[checked(parte22.QuantPontos - 1)] - parte22.PontosImportantes.get_X("F")) * 0.6, parte22.Y[checked(parte22.QuantPontos - 1)] - (parte22.Y[checked(parte22.QuantPontos - 1)] - parte22.PontosImportantes.get_Y("B")) * 0.6, -1, 0);
      int num210 = checked((int)System.Math.Round(unchecked(13.0 + num74)));
      parte22.AdicionaPique((double)checked(-num210), 0.0, -1);
      parte22.PI.AdicionaPonto("Pi1", parte22.X[checked(parte22.QuantPontos - 1)], parte22.Y[checked(parte22.QuantPontos - 1)]);
      parte22.PI.AdicionaPonto("Pi1b", parte22.X[checked(parte22.QuantPontos - 2)], parte22.Y[checked(parte22.QuantPontos - 2)]);
      parte22.AdicionaPonto(parte22.PontosImportantes.get_X("F"), parte22.PontosImportantes.get_Y("B"), -1, 0);
      parte22.AdicionaPonto(parte22.PontosImportantes.get_X("F1"), -parte22.PontosImportantes.get_Y("F1"), -1, 0);
      parte22.AdicionaPique(-0.5, 0.0, parte22.AdicionaPontoPerimetro(parte22.AchaPontoImportante("Pi1", 0), 3.5));
      parte22.AdicionaPique(-0.5, 0.0, parte22.AdicionaPontoPerimetro(parte22.AchaPontoImportante("Pi1", 0), 3.5 + num33 * 2.0));
      parte22.AdicionaPique(-0.5, 0.0, parte22.AdicionaPontoPerimetro(parte22.AchaPontoImportante("Pi1", 0), 3.5 + num33 * 2.0 + 2.0));
      parte22.AdicionaPique(-0.5, 0.0, parte22.AdicionaPontoPerimetro(parte22.AchaPontoImportante("Pi1", 0), 3.5 + num33 * 2.0 + 2.0 + num33 * 2.0));
      parte22.PI.AdicionaPonto("Pi2", parte22.X[checked(parte22.QuantPontos - 2)], parte22.Y[checked(parte22.QuantPontos - 2)]);
      parte22.PI.AdicionaPonto("F12", parte22.PI.get_X("F1"), -parte22.PI.get_Y("F1"));
      parte22.PI.AdicionaPonto("E1", parte22.PI.get_X("E"), -parte22.PI.get_Y("E"));
      parte22.PI.AdicionaPonto("D1", parte22.PI.get_X("D"), -parte22.PI.get_Y("D"));
      parte22.AdicionaCurvaSequencia("E1", 0.3453, 0.3155, 0.6701, 0.6701, num2);
      parte22.AdicionaCurvaSequencia("D1", 333.0 / 1000.0, 0.3027, 0.677, 0.6158, num2);
      parte22.AdicionaCurvaSequencia("A", 0.3293, 99.0 / 400.0, 0.6749, 0.5361, num2);
      M.AdicionaMedidaConferencia("Pique_Punho_Esq");
      M.set_MedidaConferencia("Pique_Punho_Esq", 1, parte22.PI.DistEntrePontos("F1", "Pi1"));
      M.set_MedidaConferencia("Pique_Punho_Esq", 2, parte22.PI.DistEntrePontos("Pi2", "F12"));
      if (flag12)
      {
        M.set_MedidaConferencia("Cabeça Direita", 2, M.get_MedidaConferencia("Cabeça Esquerda", 2));
        Parte parte23 = M.Partes[Parte2];
        parte23.RespeitaXadrez = true;
        parte23.PermiteDesenho = true;
        parte23.Gabarito = false;
        parte23.CopiaParte(M, index3, 0, 0, true, false);
        int num155 = parte23.AchaPontoImportante("E", 0);
        int num156 = checked(parte23.QuantPontos - 1);
        int num203 = checked(num155 + 1);
        int num204 = num156;
        int num205 = num203;
        while (num205 <= num204)
        {
          parte23.ExcluePonto(checked(num155 + 1));
          checked { ++num205; }
        }
        parte23.PI.Item[checked((int)System.Math.Round(parte23.PI.get_Indice("F")))].Y = parte23.PI.get_Y("B") - (val1_1 + num200 + num33 * 4.0) / 2.0;
        parte23.PI.Item[checked((int)System.Math.Round(parte23.PI.get_Indice("F")))].X = parte23.PI.get_X("B") + num30 - ValorRelativoY + nMargemCostura;
        parte23.PI.Item[checked((int)System.Math.Round(parte23.PI.get_Indice("F1")))].Y = parte23.PI.get_Y("F");
        parte23.PI.Item[checked((int)System.Math.Round(parte23.PI.get_Indice("F1")))].X = parte23.PI.get_X("F");
        parte23.PI.Item[checked((int)System.Math.Round(parte23.PI.get_Indice("F12")))].Y = -parte23.PI.get_Y("F1");
        parte23.PI.Item[checked((int)System.Math.Round(parte23.PI.get_Indice("F12")))].X = -parte23.PI.get_X("F1");
        parte23.AdicionaCurvaSequencia("F1", 0.3299, 0.4189, 0.6547, 0.6845, num2);
        parte23.AdicionaPonto(parte23.X[checked(parte23.QuantPontos - 1)] - (parte23.X[checked(parte23.QuantPontos - 1)] - parte23.PI.get_X("F")) * 0.6, parte23.Y[checked(parte23.QuantPontos - 1)] - (parte23.Y[checked(parte23.QuantPontos - 1)] - parte23.PI.get_Y("B")) * 0.6, -1, 0);
        int num206 = checked((int)System.Math.Round(unchecked(13.0 + num74)));
        parte23.AdicionaPique((double)checked(-num206), 0.0, -1);
        parte23.PI.AdicionaPonto("Pi1", parte23.X[checked(parte23.QuantPontos - 1)], parte23.Y[checked(parte23.QuantPontos - 1)]);
        parte23.PI.AdicionaPonto("Pi11", parte23.X[checked(parte23.QuantPontos - 1)], parte23.Y[checked(parte23.QuantPontos - 1)]);
        parte23.PI.pegaPI("Pi1b").X = parte23.X[checked(parte23.QuantPontos - 2)];
        parte23.PI.pegaPI("Pi1b").Y = parte23.Y[checked(parte23.QuantPontos - 2)];
        parte23.AdicionaPonto(parte23.PI.get_X("F"), parte23.PI.get_Y("B"), -1, 0);
        parte23.AdicionaPonto(parte23.PI.get_X("F1"), -parte23.PI.get_Y("F1"), -1, 0);
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi11", 0), 3.5));
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi11", 0), 3.5 + num33 * 2.0));
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi11", 0), 3.5 + num33 * 2.0 + 2.0));
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi11", 0), 3.5 + num33 * 2.0 + 2.0 + num33 * 2.0));
        parte23.PI.AdicionaPonto("Pi2", parte23.X[checked(parte23.QuantPontos - 2)], parte23.Y[checked(parte23.QuantPontos - 2)]);
        parte23.AdicionaCurvaSequencia("E1", 0.3453, 0.3155, 0.6701, 0.6701, num2);
        parte23.AdicionaCurvaSequencia("D1", 333.0 / 1000.0, 0.3027, 0.677, 0.6158, num2);
        parte23.AdicionaCurvaSequencia("A", 0.3293, 99.0 / 400.0, 0.6749, 0.5361, num2);
        parte23.InverteCordenadas(false, true);
        M.AdicionaMedidaConferencia("Pique_Punho_Dir");
        M.set_MedidaConferencia("Pique_Punho_Dir", 1, parte23.PI.DistEntrePontos("F12", "Pi2"));
        M.set_MedidaConferencia("Pique_Punho_Dir", 2, parte23.PI.DistEntrePontos("Pi1", "F1"));
      }
      else
      {
        Parte parte23 = M.Partes[Parte2];
        parte23.RespeitaXadrez = true;
        parte23.PermiteDesenho = true;
        parte23.Gabarito = false;
        Parte.Pontos pi11 = parte23.PI;
        pi11.AdicionaPonto("CC1", pi11.get_X("B") + (pi11.get_X("C") - pi11.get_X("B")) * 0.275, pi11.get_Y("B") + (pi11.get_Y("C") - pi11.get_Y("B")) * (261.0 / 625.0));
        pi11.AdicionaPonto("CC2", pi11.get_X("B") + (pi11.get_X("C") - pi11.get_X("B")) * 0.7935, pi11.get_Y("B") + (pi11.get_Y("C") - pi11.get_Y("B")) * 0.7644);
        pi11.AdicionaPonto("CF1", pi11.get_X("B") + (pi11.get_X("A") - pi11.get_X("B")) * 0.7112, pi11.get_Y("B") + (pi11.get_Y("A") - pi11.get_Y("B")) * 0.6613);
        pi11.AdicionaPonto("CF2", pi11.get_X("B") + (pi11.get_X("A") - pi11.get_X("B")) * 0.1097, pi11.get_Y("B") + (pi11.get_Y("A") - pi11.get_Y("B")) * (162.0 / 625.0));
        pi11.AdicionaPonto("F", pi11.get_X("B") + num30 - ValorRelativoY + nMargemCostura, pi11.get_Y("B") - (val1_1 + num200 + num33 * 4.0) / 2.0);
        pi11.AdicionaPontoRelativo("F1", "F", 0.75, 0.0);
        pi11.AdicionaPonto("G", pi11.get_X("F"), pi11.get_Y("B"));
        pi11.AdicionaPonto("D", pi11.get_X("C") + (pi11.get_X("F") - pi11.get_X("C")) * 0.2411, pi11.get_Y("C") + (pi11.get_Y("B") - ((num198 + num201) / 2.0 + 1.0) - pi11.get_Y("C")) * 0.4312);
        pi11.AdicionaPonto("E", pi11.get_X("C") + (pi11.get_X("F") - pi11.get_X("C")) * 0.605, pi11.get_Y("C") + (pi11.get_Y("B") - ((num198 + num201) / 2.0 + 1.0) - pi11.get_Y("C")) * 0.7617);
        pi11.AtualizaPonto("D", 0.0, -num21);
        pi11.AtualizaPonto("E", 0.0, -num21 * 0.75);
        parte23.AdicionaPontoImportante("A", -1, 0);
        parte23.AdicionaCurvaSequencia("CF1", 0.2063, 0.4806, 0.619, 0.7467, num2);
        parte23.AdicionaCurvaSequencia("CF2", 0.3197, 0.3718, 0.7165, 0.6195, num2);
        parte23.AdicionaCurvaSequencia("B", 0.7917, 0.2778, 0.9845, 0.4838, num2);
        parte23.AdicionaCurvaSequencia("CC1", 0.0, 0.5802, 0.5161, 0.7299, num2);
        parte23.AdicionaCurvaSequencia("CC2", 0.3561, 0.3478, 0.6606, 0.6341, num2);
        parte23.AdicionaCurvaSequencia("C", 0.5311, 0.3163, 0.8827, 0.5845, num2);
        double num155 = parte23.PerimetroEntrePontos(Conversions.ToString(parte23.AchaPontoImportante("A", 0)), Conversions.ToString(parte23.AchaPontoImportante("C", 0)));
        if (num155 > val1_2 + num29)
        {
          double MedidaPerimetro3 = (val1_2 + num29) / 2.0;
          int num156 = parte23.AdicionaPontoPerimetro(0, MedidaPerimetro3);
          int num203 = parte23.AdicionaPontoPerimetro(0, num155 - MedidaPerimetro3);
          int num204 = checked(parte23.QuantPontos - 1);
          int num205 = checked(num203 + 1);
          int num206 = num204;
          int num207 = num205;
          while (num207 <= num206)
          {
            parte23.ExcluePonto(checked(num203 + 1));
            checked { ++num207; }
          }
          int num208 = 0;
          int num209 = checked(num156 - 1);
          int num211 = num208;
          while (num211 <= num209)
          {
            parte23.ExcluePonto(0);
            checked { ++num211; }
          }
          int index27 = checked((int)System.Math.Round(parte23.PI.get_Indice("A")));
          parte23.PI.Item[index27].X = parte23.X[0];
          parte23.PI.Item[index27].Y = parte23.Y[0];
          int index28 = checked((int)System.Math.Round(parte23.PI.get_Indice("C")));
          parte23.PI.Item[index28].X = parte23.X[checked(parte23.QuantPontos - 1)];
          parte23.PI.Item[index28].Y = parte23.Y[checked(parte23.QuantPontos - 1)];
        }
        //if (!flag1)
        //{
        //  itensModelos1.set_MedidaCorpo("Peri_Cava_Dir", val1_2);
        //  itensModelos1.set_MedidaMolde("Peri_Cava_Dir", num155);
        //}
        //else
        //{
        //  ModeloNovo.set_Medida("Peri_Cava_Dir", val1_2);
        //  ModeloNovo.set_Medida("Confere_Cava_Dir", num155);
        //}

        double Peri_Cava_Dir = val1_2;
        double Confere_Cava_Dir = num155;


        M.set_MedidaConferencia("Cabeça Direita", 2, parte23.PerimetroEntrePontos("A", "C"));
        M.set_MedidaConferencia("Perimetro Cava Direita", 1, num155);
        M.set_MedidaConferencia("Perimetro Cava Direita", 2, val1_2);
        parte23.AdicionaCurvaSequencia("D", 0.3251, 0.4639, 0.6707, 301.0 / 400.0, num2);
        parte23.AdicionaCurvaSequencia("E", 0.323, 0.3842, 0.667, 0.6973, num2);
        parte23.AdicionaCurvaSequencia("F1", 0.3299, 0.4189, 0.6547, 0.6845, num2);
        parte23.AdicionaPonto(parte23.X[checked(parte23.QuantPontos - 1)] - (parte23.X[checked(parte23.QuantPontos - 1)] - parte23.PontosImportantes.get_X("F")) * 0.6, parte23.Y[checked(parte23.QuantPontos - 1)] - (parte23.Y[checked(parte23.QuantPontos - 1)] - parte23.PontosImportantes.get_Y("B")) * 0.6, -1, 0);
        int num212 = checked((int)System.Math.Round(unchecked(13.0 + num74)));
        parte23.AdicionaPique((double)checked(-num212), 0.0, -1);
        parte23.PI.AdicionaPonto("Pi1", parte23.X[checked(parte23.QuantPontos - 1)], parte23.Y[checked(parte23.QuantPontos - 1)]);
        parte23.PI.AdicionaPonto("Pi1b", parte23.X[checked(parte23.QuantPontos - 2)], parte23.Y[checked(parte23.QuantPontos - 2)]);
        parte23.AdicionaPonto(parte23.PontosImportantes.get_X("F"), parte23.PontosImportantes.get_Y("B"), -1, 0);
        parte23.AdicionaPonto(parte23.PontosImportantes.get_X("F1"), -parte23.PontosImportantes.get_Y("F1"), -1, 0);
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi1", 0), 3.5));
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi1", 0), 3.5 + num33 * 2.0));
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi1", 0), 3.5 + num33 * 2.0 + 2.0));
        parte23.AdicionaPique(-0.5, 0.0, parte23.AdicionaPontoPerimetro(parte23.AchaPontoImportante("Pi1", 0), 3.5 + num33 * 2.0 + 2.0 + num33 * 2.0));
        parte23.PI.AdicionaPonto("Pi2", parte23.X[checked(parte23.QuantPontos - 2)], parte23.Y[checked(parte23.QuantPontos - 2)]);
        parte23.PI.AdicionaPonto("F12", parte23.PI.get_X("F1"), -parte23.PI.get_Y("F1"));
        parte23.PI.AdicionaPonto("E1", parte23.PI.get_X("E"), -parte23.PI.get_Y("E"));
        parte23.PI.AdicionaPonto("D1", parte23.PI.get_X("D"), -parte23.PI.get_Y("D"));
        parte23.AdicionaCurvaSequencia("E1", 0.3453, 0.3155, 0.6701, 0.6701, num2);
        parte23.AdicionaCurvaSequencia("D1", 333.0 / 1000.0, 0.3027, 0.677, 0.6158, num2);
        parte23.AdicionaCurvaSequencia("A", 0.3293, 99.0 / 400.0, 0.6749, 0.5361, num2);
        parte23.InverteCordenadas(false, true);
        M.AdicionaMedidaConferencia("Pique_Punho_Dir");
        M.set_MedidaConferencia("Pique_Punho_Dir", 1, parte23.PI.DistEntrePontos("F1", "Pi1"));
        M.set_MedidaConferencia("Pique_Punho_Dir", 2, parte23.PI.DistEntrePontos("Pi2", "F12"));
      }
      Parte parte24 = M.Partes[index3];
      parte24.PermiteDesenho = true;
      parte24.RespeitaXadrez = true;
      double num213 = parte24.PerimetroEntrePontos("C", "F1");
      double num214 = parte24.PerimetroEntrePontos("A", "C") / (num133 + num142 + num157);
      double num215 = num133 * num214;
      double num216 = num142 * num214;
      double num217 = num157 * num214;
      num213 = num215;
      if (Operators.CompareString(Left1, "Curta", false) == 0)
      {
        double num155 = 3.0;
        int index27 = parte24.AdicionaPontoLinha("X", parte24.PontosImportantes.get_X("B") + num77, 0);
        int num156 = parte24.AdicionaPontoLinha("X", parte24.PontosImportantes.get_X("B") + num77, checked(index27 + 3));
        double num203 = parte24.X[index27];
        int num204 = checked(index27 + 1);
        int num205 = checked(num156 - 1);
        int num206 = num204;
        while (num206 <= num205)
        {
          parte24.ExcluePonto(checked(index27 + 1));
          checked { ++num206; }
        }
        parte24.Ampliacao(nMargemCostura);
        int Index2 = parte24.AdicionaPontoLinhaAmp("X", parte24.PontosImportantes.get_X("B") + num77, 0);
        int Index3 = parte24.AdicionaPontoLinhaAmp("X", parte24.PontosImportantes.get_X("B") + num77, checked(Index2 + 2));
        parte24.AdicionaPiqueAmp(0.0, -0.5, Index3);
        parte24.AdicionaPiqueAmp(0.0, 0.5, Index2);
        int index28 = parte24.AdicionaPontoLinhaAmp("X", num203 - num155, 0);
        parte24.ApagaEntrePiquesAmp(1, 2);
        double num207 = (parte24.MaximoY + parte24.MinimoY) / 2.0;
        int index29 = parte24.AdicionaPontoAmp(parte24.AmpX[index28] + num155 * 2.0, parte24.AmpY[index28], checked(Index2 + 4), 0);
        int index30 = parte24.AdicionaPontoAmp(parte24.AmpX[index28] + num155 * 3.0, parte24.AmpY[parte24.get_AchaPiqueAmp(1)], checked(Index2 + 5), 0);
        parte24.AdicionaPontoAmp(parte24.AmpX[index28] + num155 * 3.0, num207 + (num207 - parte24.AmpY[index30]), checked(Index2 + 6), 0);
        parte24.AdicionaPontoAmp(parte24.AmpX[index28] + num155 * 2.0, num207 + (num207 - parte24.AmpY[index29]), checked(Index2 + 7), 0);
        if (flag3)
          parte24.Area /= 2.0;
        parte24.TransformaPiquesAmp();
      }
      else
      {
        parte24.Ampliacao(nMargemCostura);
        int index27 = parte24.AchaPontoAmpliado(parte24.AchaPontoImportante("Pi1b", 0), nMargemCostura);
        parte24.Risca[index27] = 0;
        parte24.Risca[checked(index27 + 1)] = 0;
        if (flag3)
          parte24.Area /= 2.0;
        parte24.TransformaPiquesAmp();
        parte24.AdicionaPiqueAmp(0.3, 0.0, parte24.AdicionaPontoPerimetroAmp(0, 4.0));
      }
      Parte parte25 = M.Partes[Parte2];
      parte25.PermiteDesenho = true;
      parte25.RespeitaXadrez = true;
      double num218 = parte25.PerimetroEntrePontos("A", "F12");
      double num219 = parte25.PerimetroEntrePontos(parte25.AchaPontoImportante("C", 0), checked(parte25.QuantPontos - 1), false) / (num135 + num141 + num158);
      double num220 = num135 * num219;
      double num221 = num141 * num219;
      double num222 = num158 * num219;
      num218 = num220;
      if (Operators.CompareString(Left1, "Curta", false) == 0)
      {
        double num155 = 3.0;
        int index27 = parte25.AdicionaPontoLinha("X", parte25.PontosImportantes.get_X("B") + num77, 0);
        int num156 = parte25.AdicionaPontoLinha("X", parte25.PontosImportantes.get_X("B") + num77, checked(index27 + 3));
        double num203 = parte25.X[index27];
        int num204 = checked(index27 + 1);
        int num205 = checked(num156 - 1);
        int num206 = num204;
        while (num206 <= num205)
        {
          parte25.ExcluePonto(checked(index27 + 1));
          checked { ++num206; }
        }
        parte25.Ampliacao(nMargemCostura);
        int Index2 = parte25.AdicionaPontoLinhaAmp("X", parte25.PontosImportantes.get_X("B") + num77, 0);
        int Index3 = parte25.AdicionaPontoLinhaAmp("X", parte25.PontosImportantes.get_X("B") + num77, checked(Index2 + 2));
        parte25.AdicionaPiqueAmp(0.0, -0.5, Index3);
        parte25.AdicionaPiqueAmp(0.0, 0.5, Index2);
        int index28 = parte25.AdicionaPontoLinhaAmp("X", num203 - num155, 0);
        parte25.ApagaEntrePiquesAmp(1, 2);
        double num207 = (parte25.MaximoY + parte25.MinimoY) / 2.0;
        int index29 = parte25.AdicionaPontoAmp(parte25.AmpX[index28] + num155 * 2.0, parte25.AmpY[index28], checked(Index2 + 4), 0);
        int index30 = parte25.AdicionaPontoAmp(parte25.AmpX[index28] + num155 * 3.0, parte25.AmpY[parte25.get_AchaPiqueAmp(1)], checked(Index2 + 5), 0);
        parte25.AdicionaPontoAmp(parte25.AmpX[index28] + num155 * 3.0, num207 + (num207 - parte25.AmpY[index30]), checked(Index2 + 6), 0);
        parte25.AdicionaPontoAmp(parte25.AmpX[index28] + num155 * 2.0, num207 + (num207 - parte25.AmpY[index29]), checked(Index2 + 7), 0);
        if (flag3)
          parte25.Area /= 2.0;
        parte25.TransformaPiquesAmp();
      }
      else
      {
        parte25.Ampliacao(nMargemCostura);
        int index27 = parte25.AchaPontoAmpliado(parte25.AchaPontoImportante("Pi1b", 0), nMargemCostura);
        parte25.Risca[index27] = 0;
        parte25.Risca[checked(index27 + 1)] = 0;
        if (flag3)
          parte25.Area /= 2.0;
        parte25.TransformaPiquesAmp();
      }
      if (flag3 & Operators.CompareString(Left1, "Curta", false) != 0)
      {
        Parte parte23 = M.Partes[Parte13];
        parte23.PermiteDesenho = false;
        parte23.RespeitaXadrez = true;
        int num155 = 0;
        int num156 = checked(M.Partes[index3].QuantPontos - 1);
        int index27 = num155;
        while (index27 <= num156)
        {
          parte23.AdicionaPonto(M.Partes[index3].X[index27], M.Partes[index3].Y[index27], -1, M.Partes[index3].Amplia[index27]);
          checked { ++index27; }
        }
        int num203 = 0;
        int num204 = checked(M.Partes[index3].QuantPontosAmp - 1);
        int index28 = num203;
        while (index28 <= num204)
        {
          parte23.AdicionaPontoAmp(M.Partes[index3].AmpX[index28], M.Partes[index3].AmpY[index28], -1, M.Partes[index3].Risca[index28]);
          checked { ++index28; }
        }
        int index29 = checked(M.Partes[Parte2].QuantPontosAmp - 2);
        while (index29 >= 0)
        {
          parte23.AdicionaPontoRelativoAmp(M.Partes[Parte2].AmpX[index29] - M.Partes[Parte2].AmpX[checked(index29 + 1)], -(M.Partes[Parte2].AmpY[index29] - M.Partes[Parte2].AmpY[checked(index29 + 1)]), -1, M.Partes[Parte2].Risca[checked(index29 + 1)]);
          checked { --index29; }
        }
        parte23.Area = M.Partes[index3].Area;
        parte23.PosicionaNome();
      }
      else if (Operators.CompareString(Left1, "Curta", false) == 0)
      {
        Parte parte23 = M.Partes[Parte13];
        parte23.PermiteDesenho = true;
        parte23.RespeitaXadrez = true;
        parte23.CopiaParte(M, index3, 0, 0, false, false);
        parte23.CopiaParteAmp(M, index3, 0, 0, false);
        parte23.Area = M.Partes[index3].Area;
      }
      if (Operators.CompareString(Left1, "Curta", false) != 0)
      {
        double ValorRelativoX1 = 17.0 + num74;
        double ValorRelativoX2 = 19.0 + num74;
        Parte parte23 = M.Partes[Parte9];
        parte23.PermiteDesenho = true;
        parte23.AdicionaPonto(0.0, 0.0, -1, 0);
        parte23.AdicionaPontoRelativo(ValorRelativoX2, 0.0, -1, 0);
        parte23.AdicionaPontoRelativo(0.0, 7.0, -1, 0);
        parte23.AdicionaPontoRelativo(-ValorRelativoX2, 0.0, -1, 0);
        parte23.AdicionaPonto(parte23.X[0], parte23.Y[0], -1, 0);
        parte23.Ampliacao(0.01);
        Parte parte26 = M.Partes[Parte10];
        parte26.PermiteDesenho = true;
        parte26.AdicionaPonto(0.0, 0.0, -1, 0);
        parte26.AdicionaPontoRelativo(ValorRelativoX1, 0.0, -1, 0);
        parte26.AdicionaPontoRelativo(0.0, 2.5, -1, 0);
        parte26.AdicionaPontoRelativo(-ValorRelativoX1, 0.0, -1, 0);
        parte26.AdicionaPonto(parte26.X[0], parte26.Y[0], -1, 0);
        parte26.Ampliacao(0.01);
        double num155 = 1.5;
        bool flag13 = true;
        while (true)
        {
          if (Strings.InStr(String1_1, "Duplo", CompareMethod.Binary) == 0)
          {
            if (Strings.InStr(String1_1, "Quadrado", CompareMethod.Binary) > 0)
            {
              Parte parte27 = M.Partes[index4];
              parte27.PermiteDesenho = true;
              parte27.AdicionaPonto(0.0, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(val1_1 + num200, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(0.0, ValorRelativoY, -1, 0);
              parte27.AdicionaPontoRelativo(-val1_1 - num200, 0.0, -1, 0);
              parte27.AdicionaPonto(parte27.X[0], parte27.Y[0], -1, 0);
              Parte parte28 = M.Partes[index5];
              parte28.PermiteDesenho = true;
              parte28.AdicionaPonto(0.0, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(val2_1 + num199, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(0.0, ValorRelativoY, -1, 0);
              parte28.AdicionaPontoRelativo(-val2_1 - num199, 0.0, -1, 0);
              parte28.AdicionaPonto(parte28.X[0], parte28.Y[0], -1, 0);
            }
            else if (Strings.InStr(String1_1, "Chanfrado", CompareMethod.Binary) > 0)
            {
              Parte parte27 = M.Partes[index4];
              parte27.PermiteDesenho = true;
              parte27.AdicionaPonto(0.0, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(val1_1 + num200, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(0.0, ValorRelativoY - num155, -1, 0);
              parte27.AdicionaPontoRelativo(-num155, num155, -1, 0);
              parte27.AdicionaPontoRelativo(-val1_1 - num200 + 2.0 * num155, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(-num155, -num155, -1, 0);
              parte27.AdicionaPonto(parte27.X[0], parte27.Y[0], -1, 0);
              Parte parte28 = M.Partes[index5];
              parte28.PermiteDesenho = true;
              parte28.AdicionaPonto(0.0, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(val2_1 + num199, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(0.0, ValorRelativoY - num155, -1, 0);
              parte28.AdicionaPontoRelativo(-num155, num155, -1, 0);
              parte28.AdicionaPontoRelativo(-val2_1 - num199 + 2.0 * num155, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(-num155, -num155, -1, 0);
              parte28.AdicionaPonto(parte28.X[0], parte28.Y[0], -1, 0);
            }
            else if (Strings.InStr(String1_1, "Redondo", CompareMethod.Binary) > 0)
            {
              num155 = 3.5;
              Parte parte27 = M.Partes[index4];
              parte27.PermiteDesenho = true;
              parte27.AdicionaPonto(0.0, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(val1_1 + num200, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(0.0, ValorRelativoY - num155, -1, 0);
              parte27.AdicionaCurva(parte27.X[checked(parte27.QuantPontos - 1)], parte27.Y[checked(parte27.QuantPontos - 1)], parte27.X[checked(parte27.QuantPontos - 1)] - num155, parte27.Y[checked(parte27.QuantPontos - 1)] + num155, 0.0, 0.5, 0.5, 1.0, parte27.QuantPontos, num2, true, 1.0);
              parte27.AdicionaPontoRelativo(-val1_1 - num200 + 2.0 * num155, 0.0, -1, 0);
              parte27.AdicionaCurva(parte27.X[checked(parte27.QuantPontos - 1)], parte27.Y[checked(parte27.QuantPontos - 1)], parte27.X[checked(parte27.QuantPontos - 1)] - num155, parte27.Y[checked(parte27.QuantPontos - 1)] - num155, 0.5, 0.0, 1.0, 0.5, parte27.QuantPontos, num2, true, 1.0);
              parte27.AdicionaPonto(parte27.X[0], parte27.Y[0], -1, 0);
              Parte parte28 = M.Partes[index5];
              parte28.PermiteDesenho = true;
              parte28.AdicionaPonto(0.0, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(val2_1 + num199, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(0.0, ValorRelativoY - num155, -1, 0);
              parte28.AdicionaCurva(parte28.X[checked(parte28.QuantPontos - 1)], parte28.Y[checked(parte28.QuantPontos - 1)], parte28.X[checked(parte28.QuantPontos - 1)] - num155, parte28.Y[checked(parte28.QuantPontos - 1)] + num155, 0.0, 0.5, 0.5, 1.0, parte28.QuantPontos, num2, true, 1.0);
              parte28.AdicionaPontoRelativo(-val2_1 - num199 + 2.0 * num155, 0.0, -1, 0);
              parte28.AdicionaCurva(parte28.X[checked(parte28.QuantPontos - 1)], parte28.Y[checked(parte28.QuantPontos - 1)], parte28.X[checked(parte28.QuantPontos - 1)] - num155, parte28.Y[checked(parte28.QuantPontos - 1)] - num155, 0.5, 0.0, 1.0, 0.5, parte28.QuantPontos, num2, true, 1.0);
              parte28.AdicionaPonto(parte28.X[0], parte28.Y[0], -1, 0);
            }
          }
          else if (Strings.InStr(String1_1, "Duplo", CompareMethod.Binary) > 0)
          {
            if (Strings.InStr(String1_1, "Redondo", CompareMethod.Binary) > 0)
            {
              Parte parte27 = M.Partes[index4];
              parte27.PermiteDesenho = true;
              parte27.AdicionaPonto(0.0, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(val1_1 + num200, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(0.5, ValorRelativoY * 2.0, -1, 0);
              parte27.AdicionaPique(1.0, 1.0, -1);
              parte27.AdicionaPontoRelativo(-val1_1 - num200 - 1.0, 0.0, -1, 0);
              parte27.AdicionaPique(1.0, 1.0, -1);
              parte27.AdicionaPonto(parte27.X[0], parte27.Y[0], -1, 0);
              parte27.AdicionaPique(1.0, 1.0, parte27.AdicionaPontoPerimetro(parte27.get_AchaPique(2), num155));
              parte27.AdicionaPique(0.5, 0.5, parte27.AdicionaPontoPerimetro(parte27.get_AchaPique(1), parte27.TamanhoPerimetro(1, 2) - num155));
              parte27.AdicionaPique(1.0, 1.0, parte27.AdicionaPontoPerimetro(parte27.get_AchaPique(1), num155));
              parte27.AdicionaPique(0.5, 0.5, parte27.AdicionaPontoPerimetro(0, parte27.TamanhoPerimetro(0, 1) - num155));
              parte27.ApagaEntrePiques(4, 6);
              parte27.ApagaEntrePiques(1, 3);
              parte27.ApagaPiquesTam1();
              parte27.AdicionaCurva(parte27.X[parte27.get_AchaPique(1)], parte27.Y[parte27.get_AchaPique(1)], parte27.X[checked(parte27.get_AchaPique(1) + 3)], parte27.Y[checked(parte27.get_AchaPique(1) + 3)], 0.0, 0.5, 0.5, 1.0, checked(parte27.get_AchaPique(1) + 3), num2, false, 1.0);
              parte27.AdicionaCurva(parte27.X[parte27.get_AchaPique(2)], parte27.Y[parte27.get_AchaPique(2)], parte27.X[checked(parte27.get_AchaPique(2) + 3)], parte27.Y[checked(parte27.get_AchaPique(2) + 3)], 0.5, 0.0, 1.0, 0.5, checked(parte27.get_AchaPique(2) + 3), num2, false, 1.0);
              parte27.ExcluePique(1);
              parte27.ExcluePique(1);
              Parte parte28 = M.Partes[index5];
              parte28.PermiteDesenho = true;
              parte28.AdicionaPonto(0.0, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(val2_1 + num199, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(0.5, ValorRelativoY * 2.0, -1, 0);
              parte28.AdicionaPique(1.0, 1.0, -1);
              parte28.AdicionaPontoRelativo(-val2_1 - num199 - 1.0, 0.0, -1, 0);
              parte28.AdicionaPique(1.0, 1.0, -1);
              parte28.AdicionaPonto(parte28.X[0], parte28.Y[0], -1, 0);
              parte28.AdicionaPique(1.0, 1.0, parte28.AdicionaPontoPerimetro(parte28.get_AchaPique(2), num155));
              parte28.AdicionaPique(0.5, 0.5, parte28.AdicionaPontoPerimetro(parte28.get_AchaPique(1), parte28.TamanhoPerimetro(1, 2) - num155));
              parte28.AdicionaPique(1.0, 1.0, parte28.AdicionaPontoPerimetro(parte28.get_AchaPique(1), num155));
              parte28.AdicionaPique(0.5, 0.5, parte28.AdicionaPontoPerimetro(0, parte28.TamanhoPerimetro(0, 1) - num155));
              parte28.ApagaEntrePiques(4, 6);
              parte28.ApagaEntrePiques(1, 3);
              parte28.ApagaPiquesTam1();
              parte28.AdicionaCurva(parte28.X[parte28.get_AchaPique(1)], parte28.Y[parte28.get_AchaPique(1)], parte28.X[checked(parte28.get_AchaPique(1) + 3)], parte28.Y[checked(parte28.get_AchaPique(1) + 3)], 0.0, 0.5, 0.5, 1.0, checked(parte28.get_AchaPique(1) + 3), num2, false, 1.0);
              parte28.AdicionaCurva(parte28.X[parte28.get_AchaPique(2)], parte28.Y[parte28.get_AchaPique(2)], parte28.X[checked(parte28.get_AchaPique(2) + 3)], parte28.Y[checked(parte28.get_AchaPique(2) + 3)], 0.5, 0.0, 1.0, 0.5, checked(parte28.get_AchaPique(2) + 3), num2, false, 1.0);
              parte28.ExcluePique(1);
              parte28.ExcluePique(1);
            }
            else if (Strings.InStr(String1_1, "Chanfrado", CompareMethod.Binary) > 0)
            {
              Parte parte27 = M.Partes[index4];
              parte27.PermiteDesenho = true;
              parte27.AdicionaPonto(0.0, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(val1_1 + num200, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(0.5, ValorRelativoY * 2.0, -1, 0);
              parte27.AdicionaPique(1.0, 1.0, -1);
              parte27.AdicionaPontoRelativo(-val1_1 - num200 - 1.0, 0.0, -1, 0);
              parte27.AdicionaPique(1.0, 1.0, -1);
              parte27.AdicionaPonto(parte27.X[0], parte27.Y[0], -1, 0);
              parte27.AdicionaPique(1.0, 1.0, parte27.AdicionaPontoPerimetro(parte27.get_AchaPique(2), num155));
              parte27.AdicionaPique(1.0, 1.0, parte27.AdicionaPontoPerimetro(parte27.get_AchaPique(1), parte27.TamanhoPerimetro(1, 2) - num155));
              parte27.AdicionaPique(1.0, 1.0, parte27.AdicionaPontoPerimetro(parte27.get_AchaPique(1), num155));
              parte27.AdicionaPique(1.0, 1.0, parte27.AdicionaPontoPerimetro(0, parte27.TamanhoPerimetro(0, 1) - num155));
              parte27.ApagaEntrePiques(4, 6);
              parte27.ApagaEntrePiques(1, 3);
              parte27.ApagaPiquesTam1();
              Parte parte28 = M.Partes[index5];
              parte28.PermiteDesenho = true;
              parte28.AdicionaPonto(0.0, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(val2_1 + num199, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(0.5, ValorRelativoY * 2.0, -1, 0);
              parte28.AdicionaPique(1.0, 1.0, -1);
              parte28.AdicionaPontoRelativo(-val2_1 - num199 - 1.0, 0.0, -1, 0);
              parte28.AdicionaPique(1.0, 1.0, -1);
              parte28.AdicionaPonto(parte28.X[0], parte28.Y[0], -1, 0);
              parte28.AdicionaPique(1.0, 1.0, parte28.AdicionaPontoPerimetro(parte28.get_AchaPique(2), num155));
              parte28.AdicionaPique(1.0, 1.0, parte28.AdicionaPontoPerimetro(parte28.get_AchaPique(1), parte28.TamanhoPerimetro(1, 2) - num155));
              parte28.AdicionaPique(1.0, 1.0, parte28.AdicionaPontoPerimetro(parte28.get_AchaPique(1), num155));
              parte28.AdicionaPique(1.0, 1.0, parte28.AdicionaPontoPerimetro(0, parte28.TamanhoPerimetro(0, 1) - num155));
              parte28.ApagaEntrePiques(4, 6);
              parte28.ApagaEntrePiques(1, 3);
              parte28.ApagaPiquesTam1();
            }
            else
            {
              Parte parte27 = M.Partes[index4];
              parte27.PermiteDesenho = true;
              parte27.AdicionaPonto(0.0, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(val1_1 + num200, 0.0, -1, 0);
              parte27.AdicionaPontoRelativo(0.5, ValorRelativoY * 2.0, -1, 0);
              parte27.AdicionaPontoRelativo(-val1_1 - num200 - 1.0, 0.0, -1, 0);
              parte27.AdicionaPonto(parte27.X[0], parte27.Y[0], -1, 0);
              Parte parte28 = M.Partes[index5];
              parte28.PermiteDesenho = true;
              parte28.AdicionaPonto(0.0, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(val2_1 + num199, 0.0, -1, 0);
              parte28.AdicionaPontoRelativo(0.5, ValorRelativoY * 2.0, -1, 0);
              parte28.AdicionaPontoRelativo(-val2_1 - num199 - 1.0, 0.0, -1, 0);
              parte28.AdicionaPonto(parte28.X[0], parte28.Y[0], -1, 0);
            }
          }
          M.Partes[index5].TransformaPiquesAmp();
          M.Partes[index4].TransformaPiquesAmp();
          M.Partes[index4].Ampliacao(nMargemCostura);
          M.Partes[index4].TransformaPiquesAmp();
          M.Partes[index5].Ampliacao(nMargemCostura);
          M.Partes[index5].TransformaPiquesAmp();
          if (flag13)
          {
            Parte parte27 = M.Partes[Parte7];
            parte27.PermiteDesenho = true;
            parte27.CopiaParte(M, index5, 0, 0, false, false);
            int quantPiques1 = parte27.QuantPiques;
            int num156 = 1;
            int num203 = quantPiques1;
            int num204 = num156;
            while (num204 <= num203)
            {
              parte27.ExcluePique(1);
              checked { ++num204; }
            }
            parte27.GiraParteNovo(System.Math.PI / 4.0, 0);
            parte27.Ampliacao(0.01);
            Parte parte28 = M.Partes[Parte6];
            parte28.PermiteDesenho = true;
            parte28.CopiaParte(M, index4, 0, 0, false, false);
            int quantPiques2 = parte28.QuantPiques;
            int num205 = 1;
            int num206 = quantPiques2;
            int num207 = num205;
            while (num207 <= num206)
            {
              parte28.ExcluePique(1);
              checked { ++num207; }
            }
            parte28.GiraParteNovo(System.Math.PI / 4.0, 0);
            parte28.Ampliacao(0.01);
            flag13 = false;
            val1_1 += 2.0;
            val2_1 += 2.0;
            M.Partes[index4].LimpaParte(false);
            M.Partes[index5].LimpaParte(false);
          }
          else
            break;
        }
      }
      if (Strings.InStr(String1_2, "Sem Bolso", CompareMethod.Binary) == 0)
      {
        double num155 = (num13 - 40.0) * 0.2 + 9.2;
        double num156 = num155 * 1.1667;
        Parte parte23 = M.Partes[Parte5];
        parte23.PermiteDesenho = true;
        if (Strings.InStr(String1_2, "Quadrado", CompareMethod.Binary) > 0)
        {
          parte23.X[0] = 0.0;
          parte23.Y[0] = 0.0;
          parte23.AdicionaPontoRelativo(num156, 0.0, -1, 0);
          parte23.AdicionaPontoRelativo(0.0, num155, -1, 0);
          parte23.AdicionaPontoRelativo(-num156, 0.0, -1, 0);
          parte23.AdicionaPonto(parte23.X[0], parte23.Y[0], -1, 0);
        }
        else if (Strings.InStr(String1_2, "Chanfrado", CompareMethod.Binary) > 0)
        {
          double num203 = 0.85;
          parte23.X[0] = 0.0;
          parte23.Y[0] = 0.0;
          parte23.AdicionaPontoRelativo(num156 * num203, 0.0, -1, 0);
          parte23.AdicionaPontoRelativo(num156 * (1.0 - num203), num156 * (1.0 - num203), -1, 0);
          parte23.AdicionaPontoRelativo(0.0, num155 - num156 * 2.0 * (1.0 - num203), -1, 0);
          parte23.AdicionaPontoRelativo(-num156 * (1.0 - num203), num156 * (1.0 - num203), -1, 0);
          parte23.AdicionaPonto(0.0, num155, -1, 0);
          parte23.AdicionaPonto(parte23.X[0], parte23.Y[0], -1, 0);
        }
        else if (Strings.InStr(String1_2, "Triangular", CompareMethod.Binary) > 0)
        {
          double num203 = 0.85;
          parte23.X[0] = 0.0;
          parte23.Y[0] = 0.0;
          parte23.AdicionaPontoRelativo(num156 * num203, 0.0, -1, 0);
          parte23.AdicionaPontoRelativo(num156 * (1.0 - num203), num155 / 2.0, -1, 0);
          parte23.AdicionaPontoRelativo(-num156 * (1.0 - num203), num155 / 2.0, -1, 0);
          parte23.AdicionaPonto(0.0, num155, -1, 0);
          parte23.AdicionaPontoRelativo(-0.2, 0.0, -1, 0);
          parte23.AdicionaPique(0.0, -0.5, -1);
          parte23.AdicionaPontoRelativo(-3.8, 0.0, -1, 0);
          parte23.AdicionaPontoRelativo(-num156 * (1.0 - num203), -num155 / 2.0, -1, 0);
          parte23.AdicionaPontoRelativo(num156 * (1.0 - num203), -num155 / 2.0, -1, 0);
          parte23.AdicionaPontoRelativo(3.8, 0.0, -1, 0);
          parte23.AdicionaPique(0.0, 0.5, -1);
          parte23.AdicionaPonto(parte23.X[0], parte23.Y[0], -1, 0);
        }
        else if (Strings.InStr(String1_2, "Redondo", CompareMethod.Binary) > 0)
        {
          int NumeroParte = Parte5;
          double num203 = 0.85;
          parte23.X[0] = 0.0;
          parte23.Y[0] = 0.0;
          M.DesenhaCurva(NumeroParte, num156 * num203, 0.0, num156, num156 * (1.0 - num203), 0.5, 0.0, 1.0, 0.5, 1, num2, false);
          int Pini = checked(parte23.QuantPontos - 1);
          M.DesenhaCurva(NumeroParte, num156, num155 - num156 * (1.0 - num203), num156 * num203, num155, 0.0, 0.5, 0.5, 1.0, Pini, num2, false);
          parte23.AdicionaPonto(0.0, num155, -1, 0);
          parte23.AdicionaPonto(parte23.X[0], parte23.Y[0], -1, 0);
        }
        else if (Strings.InStr(String1_2, "Militar", CompareMethod.Binary) > 0)
        {
          parte23.AdicionaPonto(0.0, 0.0, -1, 0);
          parte23.AdicionaPonto(num156, 0.0, -1, 0);
          parte23.AdicionaPontoRelativo(0.0, (num155 + 4.0) / 2.0 - 3.0, -1, 0);
          parte23.AdicionaPique(-0.5, 0.0, -1);
          parte23.AdicionaPontoRelativo(0.0, 2.0, -1, 0);
          parte23.AdicionaPique(-0.5, 0.0, -1);
          parte23.AdicionaPontoRelativo(0.0, 2.0, -1, 0);
          parte23.AdicionaPique(-0.5, 0.0, -1);
          parte23.AdicionaPontoRelativo(0.0, 2.0, -1, 0);
          parte23.AdicionaPique(-0.5, 0.0, -1);
          parte23.AdicionaPonto(num156, num155 + 4.0, -1, 0);
          parte23.AdicionaPonto(0.0, num155 + 4.0, -1, 0);
          parte23.AdicionaPonto(parte23.X[0], parte23.Y[0], -1, 0);
        }
        if (Strings.InStr(String1_2, "Trian", CompareMethod.Binary) == 0)
        {
          parte23.Ampliacao(nMargemCostura);
          parte23.ExcluePontoAmp(-1);
          parte23.AdicionaPontoRelativoAmp(-1.0, 0.0, -1, 0);
          parte23.AdicionaPiqueAmp(0.0, -0.5, -1);
          parte23.AdicionaPontoRelativoAmp(-2.0, 0.0, -1, 0);
          parte23.AdicionaPontoAmp(-4.0, -1.0, -1, 0);
          parte23.AdicionaPontoRelativoAmp(2.0, 0.0, -1, 0);
          parte23.AdicionaPiqueAmp(0.0, 0.5, -1);
          parte23.AdicionaPontoAmp(parte23.AmpX[0], parte23.AmpY[0], -1, 0);
          parte23.AdicionaPontoAmp(parte23.X[0], parte23.Y[0], -1, 2);
          if (Strings.InStr(String1_2, "Militar", CompareMethod.Binary) > 0)
          {
            int NumeroPique = 1;
            do
            {
              parte23.AdicionaPiqueAmp(0.5, 0.0, parte23.AdicionaPontoLinhaAmp("Y", parte23.Y[parte23.get_AchaPique(NumeroPique)], checked(parte23.get_AchaPiqueAmp(4) + 3)));
              checked { ++NumeroPique; }
            }
            while (NumeroPique <= 4);
          }
          parte23.TransformaPiquesAmp();
        }
        else
        {
          parte23.Ampliacao(nMargemCostura);
          parte23.TransformaPiquesAmp();
        }
      }
      Parte parte29 = M.Partes[Parte4];
      parte29.PermiteDesenho = true;
      parte29.CopiaParte(M, index7, 0, 0, true, false);
      int index48 = parte29.AdicionaPontoLinha("X", parte29.PI.get_X("2") - 2.25, 0);
      int num223 = parte29.AdicionaPontoLinha("X", parte29.X[index48], checked(index48 + 3));
      int num224 = checked(index48 + 1);
      int num225 = checked(num223 - 1);
      int num226 = num224;
      while (num226 <= num225)
      {
        parte29.ExcluePonto(checked(index48 + 1));
        checked { ++num226; }
      }
      parte29.Ampliacao(nMargemCostura + 0.75);
      parte29.TransformaPiquesAmp();
      if (flag3)
      {
        Parte parte23 = M.Partes[Parte11];
        parte23.PermiteDesenho = false;
        parte23.RespeitaXadrez = true;
        int num155 = 0;
        int num156 = checked(M.Partes[index1].QuantPontos - 1);
        int index27 = num155;
        while (index27 <= num156)
        {
          parte23.AdicionaPonto(M.Partes[index1].X[index27], M.Partes[index1].Y[index27], -1, M.Partes[index1].Amplia[index27]);
          checked { ++index27; }
        }
        int num203 = 0;
        int num204 = checked(M.Partes[index1].QuantPontosAmp - 1);
        int index28 = num203;
        while (index28 <= num204)
        {
          parte23.AdicionaPontoAmp(M.Partes[index1].AmpX[index28], M.Partes[index1].AmpY[index28], -1, M.Partes[index1].Risca[index28]);
          checked { ++index28; }
        }
        int index29 = checked(M.Partes[index2].QuantPontosAmp - 2);
        while (index29 >= 0)
        {
          parte23.AdicionaPontoRelativoAmp(M.Partes[index2].AmpX[index29] - M.Partes[index2].AmpX[checked(index29 + 1)], -(M.Partes[index2].AmpY[index29] - M.Partes[index2].AmpY[checked(index29 + 1)]), -1, M.Partes[index2].Risca[checked(index29 + 1)]);
          checked { --index29; }
        }
        parte23.RetiraPontosIguaisAmp();
        parte23.Area = M.Partes[index1].Area;
        parte23.PosicionaNome();
      }
      //if (!flag3)
      //{
      //  if (!flag10)
      //  {
      //    Encaixe.AdicionaParte(index3, 0, 0, 3);
      //    Encaixe.AdicionaParte(Parte2, 0, 0, 3);
      //  }
      //  else
      //  {
      //    Encaixe.AdicionaParte(index3, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte2, 0, 0, 0);
      //  }
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    Encaixe.AdicionaParte(Parte9, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte10, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte9, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte10, 0, 0, 0);
      //  }
      //  Encaixe.AdicionaParte(index1, 0, 0, 3);
      //  Encaixe.AdicionaParte(index2, 0, 0, 3);
      //  Encaixe.AdicionaParte(Parte1, 0, 3, 0);
      //  Encaixe.AdicionaParte(Parte3, 0, 0, 0);
      //  Encaixe.AdicionaParte(Parte3, 0, 1, 0);
      //  if (!flag6 & !flag7)
      //  {
      //    Encaixe.AdicionaParte(index6, 0, 0, 0);
      //    Encaixe.AdicionaParte(index6, 0, 1, 0);
      //    Encaixe.AdicionaParte(index7, 0, 0, 0);
      //    Encaixe.AdicionaParte(index7, 0, 1, 0);
      //    Encaixe.AdicionaParte(Parte4, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte4, 0, 1, 0);
      //  }
      //  else
      //  {
      //    if (!flag6)
      //      Encaixe.AdicionaParte(index6, 0, 0, 0);
      //    else
      //      Encaixe.AdicionaParte(index6, 1, 0, 0);
      //    if (!flag7)
      //    {
      //      Encaixe.AdicionaParte(index6, 0, 1, 0);
      //      Encaixe.AdicionaParte(index7, 0, 0, 0);
      //      Encaixe.AdicionaParte(index7, 0, 1, 0);
      //      Encaixe.AdicionaParte(Parte4, 0, 0, 0);
      //      Encaixe.AdicionaParte(Parte4, 0, 1, 0);
      //    }
      //    else
      //    {
      //      Encaixe.AdicionaParte(index6, 0, 1, 0);
      //      Encaixe.AdicionaParte(index7, 1, 0, 0);
      //      Encaixe.AdicionaParte(index7, 1, 1, 0);
      //      Encaixe.AdicionaParte(Parte4, 1, 0, 0);
      //      Encaixe.AdicionaParte(Parte4, 1, 1, 0);
      //    }
      //  }
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    if (!flag8 & !flag9)
      //    {
      //      Encaixe.AdicionaParte(index4, 0, 0, 0);
      //      Encaixe.AdicionaParte(index4, 0, 1, 0);
      //      Encaixe.AdicionaParte(index5, 0, 0, 0);
      //      Encaixe.AdicionaParte(index5, 0, 1, 0);
      //    }
      //    else
      //    {
      //      if (!flag8)
      //      {
      //        Encaixe.AdicionaParte(index4, 0, 0, 0);
      //        Encaixe.AdicionaParte(index5, 0, 0, 0);
      //      }
      //      else
      //      {
      //        Encaixe.AdicionaParte(index4, 1, 0, 0);
      //        Encaixe.AdicionaParte(index5, 1, 0, 0);
      //      }
      //      if (!flag9)
      //      {
      //        Encaixe.AdicionaParte(index4, 0, 0, 0);
      //        Encaixe.AdicionaParte(index5, 0, 0, 0);
      //      }
      //      else
      //      {
      //        Encaixe.AdicionaParte(index4, 1, 0, 0);
      //        Encaixe.AdicionaParte(index5, 1, 0, 0);
      //      }
      //    }
      //  }
      //  if (Strings.InStr(String1_2, "Sem Bolso", CompareMethod.Binary) == 0)
      //    Encaixe.AdicionaParte(Parte5, 0, 1, 0);
      //  Encaixe.AdicionaParte(index9, 6, 0, 0);
      //  Encaixe.AdicionaParte(index8, 6, 0, 0);
      //  Encaixe.AdicionaParte(Parte8, 7, 0, 0);
      //  Encaixe.AdicionaParte(index10, 7, 0, 0);
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    Encaixe.AdicionaParte(Parte6, 6, 0, 0);
      //    Encaixe.AdicionaParte(Parte7, 6, 0, 0);
      //  }
      //}
      //else
      //{
      //  Encaixe.AdicionaParte(Parte12, 0, 0, 2);
      //  M.Partes[Parte12].NomeRisco = "A";
      //  if (flag2)
      //  {
      //    Encaixe.AdicionaParte(Parte11, 0, 0, 2);
      //    M.Partes[Parte11].NomeRisco = "B";
      //  }
      //  else
      //  {
      //    Encaixe.AdicionaParte(index1, 0, 0, 2);
      //    M.Partes[index1].NomeRisco = "B";
      //  }
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    Encaixe.AdicionaParte(Parte13, 0, 1, 3);
      //    M.Partes[Parte13].NomeRisco = "C";
      //    Encaixe.AdicionaParte(Parte9, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte10, 0, 0, 0);
      //  }
      //  else
      //  {
      //    Encaixe.AdicionaParte(index3, 0, 1, 3);
      //    M.Partes[Parte13].NomeRisco = "C";
      //  }
      //  M.Partes[Parte9].NomeRisco = "D";
      //  M.Partes[Parte10].NomeRisco = "E";
      //  Encaixe.AdicionaParte(Parte3, 0, 0, 3);
      //  M.Partes[Parte3].NomeRisco = "F";
      //  if (!flag6 & !flag7)
      //  {
      //    Encaixe.AdicionaParte(index6, 0, 0, 0);
      //    Encaixe.AdicionaParte(index7, 0, 0, 0);
      //    Encaixe.AdicionaParte(Parte4, 0, 0, 0);
      //  }
      //  else
      //  {
      //    if (!flag6)
      //      Encaixe.AdicionaParte(index6, 0, 0, 0);
      //    else
      //      Encaixe.AdicionaParte(index6, 1, 0, 0);
      //    if (!flag7)
      //    {
      //      Encaixe.AdicionaParte(index7, 0, 0, 0);
      //      Encaixe.AdicionaParte(Parte4, 0, 0, 0);
      //    }
      //    else
      //    {
      //      Encaixe.AdicionaParte(index7, 1, 0, 0);
      //      Encaixe.AdicionaParte(Parte4, 1, 0, 0);
      //    }
      //  }
      //  M.Partes[index6].NomeRisco = "G";
      //  M.Partes[index7].NomeRisco = "H";
      //  M.Partes[Parte4].NomeRisco = "I";
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    if (!flag8 & !flag9)
      //    {
      //      Encaixe.AdicionaParte(index4, 0, 0, 0);
      //      Encaixe.AdicionaParte(index5, 0, 0, 0);
      //    }
      //    M.Partes[index5].NomeRisco = "J";
      //    M.Partes[index4].NomeRisco = "K";
      //  }
      //  if (Strings.InStr(String1_2, "Sem Bolso", CompareMethod.Binary) == 0)
      //  {
      //    Encaixe.AdicionaParte(Parte5, 0, 1, 0);
      //    M.Partes[Parte5].NomeRisco = "L";
      //  }
      //  Encaixe.AdicionaParte(index9, 6, 0, 0);
      //  Encaixe.AdicionaParte(index8, 6, 0, 0);
      //  Encaixe.AdicionaParte(Parte8, 7, 0, 0);
      //  Encaixe.AdicionaParte(index10, 7, 0, 0);
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    Encaixe.AdicionaParte(Parte7, 6, 0, 0);
      //    Encaixe.AdicionaParte(Parte6, 6, 0, 0);
      //  }
      //  M.Partes[index9].NomeRisco = nameof(M);
      //  M.Partes[index8].NomeRisco = "N";
      //  if (Operators.CompareString(Left1, "Curta", false) != 0)
      //  {
      //    M.Partes[Parte7].NomeRisco = "O";
      //    M.Partes[Parte6].NomeRisco = "P";
      //  }
      //  M.Partes[Parte8].NomeRisco = "Q";
      //  M.Partes[index10].NomeRisco = "R";
      //}
      return "OK";
    }
  }
}
