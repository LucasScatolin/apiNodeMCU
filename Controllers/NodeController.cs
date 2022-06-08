using APINodeMcu.Data;
using APINodeMcu.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APINodeMcu.Controllers
{

    [ApiController]
    [Route("[Controller]")]

    public class NodeController : ControllerBase
    {

        private NodeContext _nodecontext;

        public NodeController(NodeContext context)
        {
            _nodecontext = context;
        }

        string resultado = "";


        [HttpGet]
        public async Task ExecutarAsync()
        {

            string ipNode = "http://192.168.43.205/"; //IP NodeMCU

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(ipNode);
                cliente.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await cliente.GetAsync("/");
                if (response.IsSuccessStatusCode)
                {

                    resultado = await cliente.GetStringAsync(ipNode);
                    

                    Console.WriteLine(resultado);
                }
            }

           

            ExtraiTexto extraiNode = new ExtraiTexto();

            string valorTemp = extraiNode.GetValorTEMP(resultado);
            string valorOxi = extraiNode.GetValorOXI(resultado);
            string valorFreq = extraiNode.GetValorFREQ(resultado);
            int valorDisp = extraiNode.GetValorDISP(resultado);


            // Criação de um objeto
            var valoresnode = new Dataesp(valorOxi, valorFreq, valorDisp, valorTemp);


         }

        

        
        private IActionResult Adicionar(Dataesp valoresnode)
        {
            _nodecontext.DataEsp.Add(valoresnode);
            _nodecontext.SaveChanges();
            return null;

        }
    }
}
