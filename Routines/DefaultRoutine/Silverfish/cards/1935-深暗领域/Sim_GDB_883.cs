using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_883 : SimTemplate //求救信号 Distress Signal
//[x]Summon two random 2-Cost minions. Refresh 2 Mana Crystals.
//随机召唤两个 法力值消耗为（2）的随从。复原2个 法力水晶。
	{
        

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_172);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);			

            p.mana = Math.Min(10, p.mana+2);
            p.ownMaxMana = Math.Min(10, p.ownMaxMana+2); // 复原2个 法力水晶
        }    
    }    
}