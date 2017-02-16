using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Ninject.Web.Common;
using Notes.Data.Context;
using Notes.Interfaces;
using Notes.Services;

namespace Notes
{
    public class NoteDependencyResolver: IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NoteDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<NotesContext>().ToSelf().InRequestScope();
            _kernel.Bind<INoteService>().To<NoteService>();
        }
    }
}