using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_500 : SimTemplate //* 疯入膏肓 Surrender to Madness
//[x]Destroy 3 of your ManaCrystals. Give all minionsin your deck +2/+2.
//摧毁你的三个法力水晶。使你牌库中的所有随从牌获得+2/+2。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.ownMaxMana-=3;
            else p.enemyMaxMana-=3;
        }
    }
}