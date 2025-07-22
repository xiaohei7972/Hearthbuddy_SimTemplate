using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：4 攻击力：2 生命值：4
	//Chia Drake
	//绿植幼龙
	//<b>Miniaturize</b><b>Choose One -</b> Gain<b>Spell Damage +1</b>; orDraw a spell.
	//<b>微缩</b><b>抉择：</b>获得<b>法术伤害+1</b>；或者抽一张法术牌。
	class Sim_TOY_801 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果，抽一张衍生物卡牌
            p.drawACard(CardDB.cardIDEnum.TOY_801t, ownplay, true); // 替换为实际的衍生物卡牌 ID

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
