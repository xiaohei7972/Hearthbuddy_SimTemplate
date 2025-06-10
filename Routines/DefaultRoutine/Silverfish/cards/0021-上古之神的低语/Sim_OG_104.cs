using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_104 : SimTemplate //* 暗影之握 Embrace the Shadow
//This turn, your healing effects deal damage instead.
//在本回合中，你的治疗效果转而造成等量的伤害。 
    {
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{			
            if (ownplay)
            {
                p.embracetheshadow++;
            }
		}
	}
}