using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_339 : SimTemplate //* 圣殿骑士队长 templarcaptain
	{
		//<b>突袭</b>。 在该随从攻击一个随从后，召唤一个5/5并具有<b>嘲讽</b>的防御者。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_342t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = p.ownMinions.Count;
            if (!target.isHero)
            {
                p.callKid(kid, pos+1, ownplay);
            }
        }
		
	}
}
