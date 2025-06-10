using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：4
	//Frost Lich Cross-Stitch
	//霜巫十字绣
	//Deal $3 damage to a character. If it dies, summon a 3/6 Water Elemental that <b><b>Freeze</b>s</b>.
	//对一个角色造成$3点伤害。如果该角色死亡，召唤一个3/6的可以<b><b>冻结</b></b>攻击目标的水元素。
	class Sim_TOY_377 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 对目标造成3点伤害
            p.minionGetDamageOrHeal(target, 3);

            // 如果目标死亡，则召唤一个3/6的水元素
            if (target.Hp <= 0)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_033), p.ownMinions.Count, ownplay);
            }
        }
    }
}
