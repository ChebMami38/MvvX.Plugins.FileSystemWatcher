﻿namespace MvvX.Plugins.FileSystemWatcher
{
    public enum WatcherChangeTypes
    {
        Created = 1,
        Deleted = 2,
        Changed = 4,
        Renamed = 8,
        All = 15
    }
}
