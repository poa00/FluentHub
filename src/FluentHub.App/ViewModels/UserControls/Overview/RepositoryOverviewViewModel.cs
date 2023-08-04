// Copyright (c) FluentHub
// Licensed under the MIT License. See the LICENSE.

using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace FluentHub.App.ViewModels.UserControls.Overview
{
    public class RepositoryOverviewViewModel : ObservableObject
    {
        public RepositoryOverviewViewModel()
        {
            GoOwnerProfileCommand = new RelayCommand(GoOwnerProfile);
        }

        #region Fields and Properties
        private string _repositoryOwnerLogin;
        public string RepositoryOwnerLogin { get => _repositoryOwnerLogin; set => SetProperty(ref _repositoryOwnerLogin, value); }

        private string _repositoryName;
        public string RepositoryName { get => _repositoryName; set => SetProperty(ref _repositoryName, value); }

        private string _selectedTag;
        public string SelectedTag { get => _selectedTag; set => SetProperty(ref _selectedTag, value); }

        private Repository _repository;
        public Repository Repository { get => _repository; set => SetProperty(ref _repository, value); }

        public static Repository StoredRepository;

        private string _viewerSubscriptionState;
        public string ViewerSubscriptionState { get => _viewerSubscriptionState; set => SetProperty(ref _viewerSubscriptionState, value); }

        public ICommand GoOwnerProfileCommand { get; private set; }
        #endregion

        #region Command methods
        private void GoOwnerProfile()
        {
            var service = Ioc.Default.GetRequiredService<INavigationService>();

            if (Repository.IsInOrganization)
            {
                service.Navigate<Views.Organizations.OverviewPage>(
                    new FrameNavigationParameter()
                    {
                        UserLogin = Repository.Owner.Login,
                    });
            }
            else
            {
                service.Navigate<Views.Users.OverviewPage>(
                    new FrameNavigationParameter()
                    {
                        UserLogin = Repository.Owner.Login,
                    });
            }
        }
        #endregion
    }
}
