using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：4
	//Flash Sale
	//光速抢购
	//Summon a 1/2 Mech with <b>Divine Shield</b> and <b>Taunt</b>. Give your minions +1/+2.
	//召唤一个1/2并具有<b>圣盾</b>和<b>嘲讽</b>的机械。使你的随从获得+1/+2。
	class Sim_TOY_716 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 召唤一个1/2并具有圣盾和嘲讽的机械
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BG_GVG_085), p.ownMinions.Count, ownplay);

            // 对所有己方随从进行+1/+2的增益
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetBuffed(m, 1, 2);
            }
        }

    }
}
