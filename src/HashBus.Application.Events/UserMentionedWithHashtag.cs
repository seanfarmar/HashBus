﻿using NServiceBus;
using System;

namespace HashBus.Application.Events
{
    public class UserMentionedWithHashtag : IEvent
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

        public long? UserMentionId { get; set; }

        public string UserMentionIdStr { get; set; }

        public string UserMentionName { get; set; }

        public string UserMentionScreenName { get; set; }
    }
}
