﻿using System;
using System.Collections.Generic;
using NServiceBus;

namespace HashBus.Twitter.Events
{
    public class HashtagTweeted : IEvent
    {
        public string Hashtag { get; set; }

        public long TweetId { get; set; }

        public DateTime TweetCreatedAt { get; set; }

        public long TweetCreatedById { get; set; }

        public string TweetCreatedByIdStr { get; set; }

        public string TweetCreatedByName { get; set; }

        public string TweetCreatedByScreenName { get; set; }

        public bool TweetIsRetweet { get; set; }

        public string TweetText { get; set; }

        public IList<UserMention> TweetUserMentions { get; set; }
    }
}
