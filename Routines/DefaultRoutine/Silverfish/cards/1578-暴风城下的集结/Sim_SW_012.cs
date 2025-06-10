using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_012 : SimTemplate //* 暗影布缝针 Shadowcloth Needle
	{
        //[x]After you cast a Shadowspell, deal 1 damageto all enemies.Lose 1 Durability.
        //在你施放一个暗影法术后，对所有敌人造成1点伤害。失去1点耐久度。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_012), true);
        }

    }
}
