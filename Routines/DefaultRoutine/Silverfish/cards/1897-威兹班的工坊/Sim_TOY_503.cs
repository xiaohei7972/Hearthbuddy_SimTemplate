using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：7 攻击力：3 生命值：7
	//Shining Sentinel
	//闪岩哨兵
	//<b>Taunt</b>, <b>Elusive</b><b>Battlecry:</b> Summon acopy of this.
	//<b>嘲讽</b>。<b>扰魔</b><b>战吼：</b>召唤一个本随从的复制。
	class Sim_TOY_503 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 召唤一个该随从的复制体
            if (p.ownMinions.Count < 7) // 确保场上有空位
            {
                p.callKid(own.handcard.card, p.ownMinions.Count, own.own);
                Minion copy = p.ownMinions[p.ownMinions.Count - 1];

                // 复制所有关键属性
                copy.Angr = own.Angr;
                copy.Hp = own.Hp;
                copy.maxHp = own.maxHp;
                copy.taunt = own.taunt;
                copy.stealth = own.stealth;
            }
        }
    }
}
