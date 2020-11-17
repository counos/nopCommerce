﻿using System;
using System.Reflection;

namespace Nop.Data.Migrations
{
    /// <summary>
    /// Represents a migration manager
    /// </summary>
    public interface IMigrationManager
    {
        /// <summary>
        /// Executes all found (and unapplied) migrations
        /// </summary>
        /// <param name="assembly">Assembly to find the migration;
        /// leave null to search migration on the whole application pull</param>
        /// <param name="isUpdateProcess">Indicates whether the upgrade or installation process is ongoing. True - if an upgrade process</param>
        void ApplyUpMigrations(Assembly assembly = null, bool isUpdateProcess = false);

        /// <summary>
        /// Executes an Down migration
        /// </summary>
        /// <param name="assembly">Assembly to find the migration;
        /// leave null to search migration on the whole application pull</param>
        void ApplyDownMigrations(Assembly assembly = null);

        /// <summary>
        /// Get an entity descriptor for entity type
        /// </summary>
        /// <param name="entityType">Entity type</param>
        /// <returns>An entity descriptor</returns>
        EntityDescriptor GetEntityDescriptor(Type entityType);
    }
}