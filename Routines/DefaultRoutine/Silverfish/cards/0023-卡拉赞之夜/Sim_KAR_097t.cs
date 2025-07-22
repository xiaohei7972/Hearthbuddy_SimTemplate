using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_097t : SimTemplate //* 埃提耶什 Atiesh
//[x]After you cast a spell,summon a randomminion of that Cost.Lose 1 Durability.
//在你施放一个法术后，随机召唤一个法力值消耗相同的随从。失去1点耐久度。 
	{
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_097t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
	}
}