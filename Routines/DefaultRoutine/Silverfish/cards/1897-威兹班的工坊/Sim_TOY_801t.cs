using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：1 攻击力：1 生命值：1
	//Chia Drake
	//绿植幼龙
	//<b>Mini</b><b>Choose One -</b> Gain<b>Spell Damage +1</b>; orDraw a spell.
	//<b>微型</b><b>抉择：</b>获得<b>法术伤害+1</b>；或者抽一张法术牌。
	class Sim_TOY_801t : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1)
            {
                // 选项1：获得法术伤害+1
                p.ownHero.spellpower++;
            }
            else if (choice == 2)
            {
                // 选项2：抽一张法术牌
                p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            }
        }
    }
}
