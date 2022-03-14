﻿namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as an accessor
    /// of each form.
    /// </summary>
    public class FormProvider
    {
        /// <summary>
        /// Manages a single instance of LoginForm.
        /// </summary>
        public static LoginForm LoginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    _loginForm = new LoginForm();
                }
                return _loginForm;
            }
        }
        private static LoginForm _loginForm;
    }
}
