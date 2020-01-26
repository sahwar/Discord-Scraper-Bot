﻿using Discord;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordScraperBot.BotMessages
{
    public interface IBotMessage
    {
        public Embed GetEmbed();

        public ulong GetChannelID();
        public void SetChannelID(ulong channelID);

    }
}
