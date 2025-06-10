using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：0
	//Flourish
	//繁茂似锦
	//Refresh yourMana Crystals.
	//复原你的法力水晶。
	class Sim_TTN_903t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.mana = p.ownMaxMana; // 复原法力水晶
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4), p.ownMinions.Count, true, false);
        }
    }
}
