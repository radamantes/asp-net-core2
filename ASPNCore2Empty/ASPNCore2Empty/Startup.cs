using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ASPNCore2Empty.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNCore2Empty
{
    public class Startup
    {
        public IConfiguration _config { get; set; }

        public Startup(IHostingEnvironment env)
        {

            //arquivo que quero ler arquivo de configuracao criado no construtor
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //definir o caminho base para saber aonde fica a pasta root
                .AddJsonFile("appsettings.json");

            _config = builder.Build();

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //REGISTRANDO UM SERVICO - 1 INTERFACE     2 - IMPLEMENTACAO INTERFACE
            //services.AddSingleton<IMensagemService, TextoMensagemService>();

            //ENVIANDO O ARQUIVO JÁ CRIADO PARA O CONTRUTOR DA CLASSE ConfigurationMensagemService
            services.AddSingleton( provider => _config);
            services.AddSingleton<IMensagemService, ConfigurationMensagemService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env , IMensagemService msg) //IMensagemService msg injetando dependência
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();

            app.Run(async (context) =>
            {
                //var mensagem = _config["Mensagem"];
                //var conexao = _config["ConnectionStrings:DefaultConnection"];

                //await context.Response.WriteAsync(mensagem);
                //await context.Response.WriteAsync(conexao);

                await context.Response.WriteAsync(msg.GetMensagem());
            });
        }
    }
}
