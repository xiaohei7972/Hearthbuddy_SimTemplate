using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：0
	//Bountiful Harvest
	//丰饶收获
	//Restore your heroto full Health.
	//为你的英雄恢复所有生命值。
	class Sim_TTN_903t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.ownHero.Hp = p.ownHero.maxHp; // 恢复所有生命值
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4), p.ownMinions.Count, true, false);
        }
    }
}
