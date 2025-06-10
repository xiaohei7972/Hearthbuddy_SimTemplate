using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_203 : SimTemplate //* 塑影匠师斯卡布斯 shadowcrafterscabbs
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_203t);
        //<b>战吼：</b>将所有随从移回拥有者的手牌。召唤两个4/2并具有<b>潜行</b>的影子。
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            foreach (Minion om in p.ownMinions)
            {
                p.drawACard(om.name, true, true);
            }
            foreach (Minion em in p.enemyMinions)
            {
                p.drawACard(em.name, false, true);
            }
            p.ownMinions.Clear();
            p.enemyMinions.Clear();
            p.callKid(kid, m.zonepos, m.own);
            p.callKid(kid, m.zonepos-1, m.own);

        }
	}
}
