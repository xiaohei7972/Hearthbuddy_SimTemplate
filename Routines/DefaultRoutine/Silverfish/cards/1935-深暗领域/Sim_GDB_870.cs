using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：2 攻击力：1 生命值：3
	//Eredar Skulker
	//艾瑞达潜藏者
	//[x]<b>Combo and <b>Spellburst</b>:</b>Gain +2 Attack and <b>Stealth</b>.
	//<b>连击，<b>法术迸发</b>：</b>获得+2攻击力和<b>潜行</b>。
	class Sim_GDB_870 : SimTemplate
	{
		
		/// <summary>
        /// 连击效果实现
        /// </summary>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay && p.cardsPlayedThisTurn > 0)
            {
                // 连击效果：获得+2攻击力和潜行
                target.Angr += 2;
                target.stealth = true;
            }
        }

        /// <summary>
        /// 法术迸发效果实现
        /// </summary>
		public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
            if (m.own)
            {
                // 法术迸发效果：获得+2攻击力和潜行
                m.Angr += 2;
                m.stealth = true;
            }
        }
	}
}
