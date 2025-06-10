using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_431: SimTemplate //* 旋翼滑翔者 Whirliglider
//<b>Battlecry:</b> Summon a 0/2_Goblin Bomb.
//<b>战吼：</b>召唤一个0/2的地精炸弹。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_031); 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos - 1, own.own); 
        }
	}
}