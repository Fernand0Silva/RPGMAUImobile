﻿using AppRpgEtec.Views.Personagens;

namespace AppRpgEtec
{
    public partial class AppShell : Shell
    {
        private CadastroPersonagemView viewModel;

        public AppShell()
        {
            InitializeComponent();

            string login = Preferences.Get("UsuarioUsername", string.Empty);
            lblLogin.Text = login;

            Routing.RegisterRoute("cadPersonagemView", typeof(CadastroPersonagemView));
        }
    }
}
