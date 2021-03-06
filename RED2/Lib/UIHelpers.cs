﻿using System;

namespace RED2
{
    /// <summary>
    /// Icon names (Warning: Entries are case sensitive)
    /// </summary>
    public enum DirectoryIcons
    {
        home,
        deleted,
        protected_icon,
        folder_warning
    }

    /// <summary>
    /// List box container class thingy
    /// </summary>
    public class DeleteModeItem
    {
        public DeleteModes DeleteMode { get; set; }

        public DeleteModeItem(DeleteModes Mode)
        {
            this.DeleteMode = Mode;
        }

        public static DeleteModes[] GetList()
        {
            return new DeleteModes[] { 
                DeleteModes.RecycleBin, 
                DeleteModes.RecycleBinShowErrors,
                DeleteModes.RecycleBinWithQuestion,
                DeleteModes.Direct,
                DeleteModes.Simulate
            };
        }

        public override string ToString()
        {
            switch (this.DeleteMode)
            {
                case DeleteModes.RecycleBin:
                    return "Delete to recycle bin (Default)";

                case DeleteModes.RecycleBinShowErrors:
                    return "Delete to recycle bin and show error messages (can be annoying)";

                case DeleteModes.RecycleBinWithQuestion:
                    return "Delete to recycle bin and ask before every deletion (can be very annoying)";

                case DeleteModes.Direct:
                    return "Delete directly and don't ask any questions (old RED mode)";

                case DeleteModes.Simulate:
                    return "Simulate deletion (just pretend doing it)";

                // TODO: Idea -> Move files instead of deleting?

                default:
                    throw new Exception("Unknown delete mode");
            }
        }
    }
}
