﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using DrionStore.Domain.Abstract;
using DrionStore.Domain.Concrete;

namespace DrionStore.WebUI.Infrastructure
{
    /// <summary>
    /// dependency resolver for instantiating objects.
    /// </summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // binding for the database.
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}