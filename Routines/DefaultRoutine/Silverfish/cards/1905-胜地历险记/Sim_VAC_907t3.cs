using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：7
	//Moonkin Constellation
	//枭兽星座
	//Refresh 3 Mana Crystals.
	//复原三个法力水晶。
	class Sim_VAC_907t3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.mana = Math.Min(10, p.mana+3); // 复原3个 法力水晶
            p.ownMaxMana = Math.Min(10, p.ownMaxMana+3); // 复原2个 法力水晶
        }    
		
	}
}
