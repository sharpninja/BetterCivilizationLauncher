using System;

using BetterCivilizationLauncher.ViewModels;

using Xunit;

namespace BetterCivilizationLauncher.Tests.XUnit
{
    // TODO: Add appropriate tests
    public class Tests
    {
        [Fact]
        public void TestMethod1()
        {
        }

        // TODO: Add tests for functionality you add to LauncherViewModel.
        [Fact]
        public void TestLauncherViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new LauncherViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to NewsViewModel.
        [Fact]
        public void TestNewsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new NewsViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to SettingsViewModel.
        [Fact]
        public void TestSettingsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SettingsViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to SystemsViewModel.
        [Fact]
        public void TestSystemsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SystemsViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to WebViewViewModel.
        [Fact]
        public void TestWebViewViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new WebViewViewModel();
            Assert.NotNull(vm);
        }
    }
}
