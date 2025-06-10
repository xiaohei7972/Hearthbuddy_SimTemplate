using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Frosty Décor
	//冰霜摆件
	//Summon two 2/4 Elementals with <b>Taunt</b> and "<b>Deathrattle</b>: Gain4 Armor".
	//召唤两个2/4并具有<b>嘲讽</b>和“<b>亡语：</b>获得4点护甲值”的元素。
	class Sim_VAC_305 : SimTemplate
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_305t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
        }
    }
}
