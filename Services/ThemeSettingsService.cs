﻿using System.Linq;
using Orchard.Data;
using PJS.ReTouch.Models;

namespace PJS.ReTouch.Services {
    public class ThemeSettingsService : IThemeSettingsService {
        private readonly IRepository<ThemeSettingsRecord> _repository;

        public ThemeSettingsService(IRepository<ThemeSettingsRecord> repository) {
            _repository = repository;
        }

        public ThemeSettingsRecord GetSettings() {
            var settings = _repository.Table.SingleOrDefault();

            if (settings == null) {
                _repository.Create(settings = new ThemeSettingsRecord());
            }

            return settings;
        }
    }
}