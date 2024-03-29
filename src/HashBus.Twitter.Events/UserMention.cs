﻿namespace HashBus.Twitter.Events
{
    using System.Collections.Generic;

    public class UserMention
    {
        public long? Id { get; set; }

        public string IdStr { get; set; }

        public IList<int> Indices { get; set; }

        public string Name { get; set; }

        public string ScreenName { get; set; }
    }
}
