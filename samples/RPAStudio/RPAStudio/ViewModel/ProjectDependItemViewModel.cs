﻿using GalaSoft.MvvmLight;
using RPA.Interfaces.Service;

namespace RPAStudio.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ProjectDependItemViewModel : ProjectBaseItemViewModel
    {
        private IServiceLocator _serviceLocator;

        public ProjectDependItemViewModel(IServiceLocator serviceLocator) : base(serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }
    }
}