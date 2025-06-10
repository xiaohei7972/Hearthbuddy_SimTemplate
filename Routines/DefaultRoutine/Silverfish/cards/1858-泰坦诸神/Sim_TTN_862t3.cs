using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：0
	//Argunite Army
	//阿古尼特大军
	//Summon four 2/2 Elementals with <b>Taunt</b>.
	//召唤四个2/2并具有<b>嘲讽</b>的元素。
	class Sim_TTN_862t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 4; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_862t4), p.ownMinions.Count, true, false); // 召唤4个2/2并具有嘲讽的元素
            }
        }
    }
}
