using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_533 : SimTemplate //* 荆棘护卫 Thorngrowth Sentries
	{
        //Summon two 1/2 Turtles with <b>Taunt</b>.
        //召唤两只1/2并具有<b>嘲讽</b>的龟。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_533t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            for (int i = 0; i <= 2; i++) p.callKid(kid, pos, ownplay);
        }

       }
}
