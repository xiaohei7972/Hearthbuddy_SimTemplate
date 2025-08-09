using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace HREngine.Bots
{
    public class SimTemplate
    {
        /// <summary>
        /// 获取卡牌的打出条件
        /// </summary>
        /// <returns></returns>
        public virtual PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] { };
        }

        /// <summary>
        /// 获取技能的使用条件
        /// </summary>
        /// <returns></returns>
        public virtual PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[] { };
        }

        /// <summary>
        /// 荣耀击杀效果(随从)
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="w">随从</param>
        public virtual void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            return;
        }

        /// <summary>
        /// 荣耀击杀效果（武器）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="w">武器</param>
        public virtual void OnHonorableKill(Playfield p, Weapon w, Minion target)
        {
            return;
        }

        /// <summary>
        /// 荣耀击杀效果（卡牌）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">具有荣耀击杀效果的卡牌</param>
        public virtual void OnHonorableKill(Playfield p, Handmanager.Handcard hc, Minion target)
        {
            return;
        }

        /// <summary>
        /// 超杀效果（武器）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="w">武器</param>
        public virtual void OnOverkill(Playfield p, Weapon w)
        {
            return;
        }

        /// <summary>
        /// 超杀效果（随从）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">具有超杀效果的随从</param>
        public virtual void OnOverkill(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 当随从造成超杀时触发该方法。
        /// 子类可以重写此方法，以在超杀发生时执行特定的逻辑。
        /// 超杀是指随从对敌方造成的伤害超过其剩余生命值。
        /// </summary>
        /// <param name="p">场面，包含当前游戏状态的信息。</param>
        /// <param name="attacker">执行超杀攻击的随从。</param>
        /// <param name="target">被攻击并被超杀的目标随从。</param>
        public virtual void onOverkill(Playfield p, Minion attacker, Minion target)
        {
            return;
        }

        /// <summary>
        /// 法术迸发效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">具有法术迸发的随从</param>
        /// <param name="hc">触发法术迸发的法术牌</param>
        public virtual void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
            return;
        }

        /// <summary>
        /// 法术迸发（武器）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="w">武器</param>
        /// <param name="hc">触发法术迸发的法术牌</param>
        public virtual void OnSpellburst(Playfield p, Weapon w, Handmanager.Handcard hc)
        {
            return;
        }

        /// <summary>
        /// 奥秘的效果，暂时只在猜奥秘时猜崇高牺牲和误导时触发，其他卡牌暂无效果
        /// 请尽量不要使用这个方法，以便重构
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="ownplay">是否自己打出</param>
        /// <param name="attacker">攻击方</param>
        /// <param name="target">被攻击的目标</param>
        /// <param name="number">新的目标</param>
        public virtual void onSecretPlay(Playfield p, bool ownplay, Minion attacker, Minion target, out int number)
        {
            number = 0;
        }

        /// <summary>
        /// 奥秘的效果，暂时只在猜奥秘时猜冰冻陷阱、寒冰屏障、忏悔、审判、狙击时触发，其他卡牌暂无效果
        /// 请尽量不要使用这个方法，以便重构
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="ownplay">是否自己打出</param>
        /// <param name="target">被攻击的目标</param>
        /// <param name="number">仅在猜寒冰屏障时有效，值为受到的攻击</param>
        public virtual void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            return;
        }

        /// <summary>
        /// 奥秘的效果，暂时只在猜奥秘时猜爆炸陷阱、捕熊陷阱、毒蛇陷阱、以眼还眼、豹子戏法、救赎、复仇、毒镖陷阱时触发，其他卡牌暂无效果
        /// 请尽量不要使用这个方法，以便重构
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="ownplay">是否自己打出</param>
        /// <param name="number">仅在猜以眼还眼时有效，值为受到的攻击</param>
        public virtual void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            return;
        }


        /// <summary>
        /// 打出卡牌时的效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="ownplay">是否自己打出</param>
        /// <param name="target">选定目标</param>
        /// <param name="choice">选项（抉择、发现等）</param>
        public virtual void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            return;
        }

        /// <summary>
        /// 当一张卡牌被打出时触发该方法。
        /// 子类可以重写此方法，以在卡牌被打出时执行特定的逻辑。
        /// 此方法可以处理随从卡牌、法术卡牌等的打出效果。
        /// </summary>
        /// <param name="p">场面，包含当前游戏状态的信息。</param>
        /// <param name="ownplay">指示卡牌是否由己方打出。true 表示己方打出，false 表示对方打出。</param>
        /// <param name="target">选定的目标随从。如果卡牌不需要目标，则此值可能为 null。</param>
        /// <param name="choice">在有多个选择的情况下使用，例如抉择或发现。表示玩家的选择。</param>
        /// <param name="hc">表示打出的具体手牌信息，可以包含法力值、卡牌类型等信息。</param>

        public virtual void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            return;
        }

        /// <summary>
        /// 流放效果（法术牌）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="own">是否自己打出</param>
        public virtual void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
        {
            return;
        }
        /// <summary>
        /// 流放效果（随从牌）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
        {
            return;
        }

        /// <summary>
        /// 弃牌时触发
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="hc">被弃掉的手牌</param>
        /// <param name="own">仅当当前随从为玛克扎尔的小鬼时生效，值为当前随从（玛克扎尔的小鬼）</param>
        /// <param name="num">仅当当前随从为玛克扎尔的小鬼时生效，值为弃牌数量</param>
        /// <param name="checkBonus">是否检查额外效果。实际影响不明</param>
        /// <returns></returns>
        public virtual void onCardIsDrawn(Playfield p, bool ownplay, Minion triggerEffectMinion)
        {

        }
        public virtual bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus = false)
        {
            return false;
        }


        /// <summary>
        /// 被弃时触发
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="hc">被弃掉的手牌</param>
        /// <returns></returns>
        public virtual void onHandCardRemoved(Playfield p, Handmanager.Handcard hc)
        {
            return;
        }

        /// <summary>
        /// 战吼效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="own">随从</param>
        /// <param name="target">选定目标</param>
        /// <param name="choice">选项（抉择、发现等）</param>
        public virtual void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            return;
        }

        /// <summary>
        /// 光环类效果进场时触发
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onAuraStarts(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 光环类效果离场时触发
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onAuraEnds(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 流放效果（法术牌）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="own">是否自己打出</param>
        public virtual void onOutcast(Playfield p, bool own)
        {
            return;
        }
        /// <summary>
        /// 流放效果（随从牌）
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onOutcast(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 休眠结束起床效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onDormantEndsTrigger(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 激怒效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onEnrageStart(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 失去激怒效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="m">随从</param>
        public virtual void onEnrageStop(Playfield p, Minion m)
        {
            return;
        }

        /// <summary>
        /// 随从受到治疗效果效果，只在北郡牧师和法力晶簇上触发
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="triggerEffectMinion">特效随从（不是被治疗的随从）</param>
        /// <param name="minionsGotHealed">被治疗的随从的数量</param>
        public virtual void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, int minionsGotHealed)
        {
            return;
        }

        /// <summary>
        /// 英雄受到治疗效果，不会被触发，因此没有任何用
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="triggerEffectMinion">特效随从（不是被治疗的随从）</param>
        /// <param name="ownerOfHeroGotHealed">是否自己被治疗</param>
        public virtual void onAHeroGotHealedTrigger(Playfield p, Minion triggerEffectMinion, bool ownerOfHeroGotHealed)
        {
            return;
        }

        /// <summary>
        /// 任意角色受到治疗的效果，只在几个随从身上触发
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="charsGotHealed"></param>
        public virtual void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            return;
        }

        /// <summary>
        /// 回合结束效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="triggerEffectMinion">有回合结束效果的随从</param>
        /// <param name="turnEndOfOwner">是否己方回合结束</param>
        public virtual void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            return;
        }
        /// <summary>
        /// 回合结束效果(重载)
        /// 当卡牌在手牌时,回合结束触发此效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="hc">有回合结束效果的手牌</param>
        /// <param name="turnEndOfOwner">是否己方回合结束</param>
        public virtual void onTurnEndsTrigger(Playfield p, Handmanager.Handcard hc, bool turnEndOfOwner)
        {
            return;
        }

        /// <summary>
        /// 回合开始效果
        /// </summary>
        /// <param name="p">场面</param>
        /// <param name="triggerEffectMinion">有回合开始效果的随从</param>
        /// <param name="turnStartOfOwner">是否己方回合开始</param>
        public virtual void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            return;
        }

        /// <summary>
        /// 当武器发生变化时触发的事件处理方法。
        /// 子类可以重写此方法，以在武器变化时执行自定义逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <param name="ownplay">布尔值，指示武器变化是否由己方触发。true 表示己方武器变化，false 表示敌方武器变化。</param>
        public virtual void onWeaponChanged(Playfield p, bool ownplay)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当随从攻击时触发此方法。
        /// 子类可以重写此方法来实现特定的攻击行为逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="attacker">进行攻击的随从。</param>
        /// <param name="target">攻击目标随从。</param>
        public virtual void onMinionAttack(Playfield p, Minion attacker, Minion target)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当随从攻击时触发此方法。
        /// 子类可以重写此方法来实现特定的攻击行为逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="attacker">进行攻击的随从。</param>
        /// <param name="target">攻击目标随从。</param>
        public virtual void afterMinionAttack(Playfield p, Minion attacker, Minion target)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }


        /// <summary>
        /// 当随从造成伤害时触发的处理方法。
        /// 该方法可以在子类中重写，以处理特定随从的伤害效果。
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <param name="attacker">造成伤害的随从。</param>
        /// <param name="damageDone">此次攻击或效果造成的伤害量。</param>
        /// <param name="ownplay">布尔值，指示此效果是否由己方触发。</param>
        public virtual void onDamageDealtByMinion(Playfield p, Minion attacker, int damageDone, bool ownplay)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }


        /// <summary>
        /// 当一个或多个随从受到伤害时触发。
        /// 子类可以重写此方法，以在随从受到伤害时执行特定逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        /// <param name="anzOwnMinionsGotDmg">受到伤害的己方随从数量。</param>
        /// <param name="anzEnemyMinionsGotDmg">受到伤害的敌方随从数量。</param>
        /// <param name="anzOwnHeroGotDmg">己方英雄是否受到伤害。</param>
        /// <param name="anzEnemyHeroGotDmg">敌方英雄是否受到伤害。</param>
        public virtual void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当随从死亡时触发。
        /// 子类可以重写此方法，以在随从死亡时执行特定逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        /// <param name="diedMinion">死亡的随从。</param>
        public virtual void onMinionDiedTrigger(Playfield p, Minion triggerEffectMinion, Minion diedMinion)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当一个随从被召唤时触发。
        /// 子类可以重写此方法，以在随从被召唤时执行特定逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        /// <param name="summonedMinion">被召唤的随从。</param>
        public virtual void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当随从被召唤后（进入场地）触发。
        /// 子类可以重写此方法，以在随从进入场地后执行特定逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        /// <param name="summonedMinion">被召唤的随从。</param>
        public virtual void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当随从的亡语效果触发时调用。
        /// 子类可以重写此方法，以处理亡语效果。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="m">触发亡语效果的随从。</param>
        public virtual void onDeathrattle(Playfield p, Minion m)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 本牌在场上时,当卡牌即将被打出时触发。
        /// 子类可以重写此方法，以在卡牌打出前执行特定逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="hc">即将被打出的手牌。</param>
        /// <param name="wasOwnCard">是否是己方卡牌。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        public virtual void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 本牌在手牌或者为英雄技能时，当卡牌即将被打出时触发（重载）。
        /// 子类可以重写此方法，以在卡牌打出前执行特定逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="hc">即将被打出的手牌。</param>
        /// <param name="wasOwnCard">是否是己方卡牌。</param>
        /// <param name="triggerhc">触发此效果的手牌。</param>
        public virtual void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 本牌在场上时,当随从牌打出后触发
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="playedMinion">打出后的随从。</param>
        /// <param name="wasOwnCard">是否是己方卡牌。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        public virtual void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 本牌在场上时,当卡牌被打出后触发。目前写了也没用,playfiled没调用
        /// 子类可以重写此方法，以在卡牌打出后执行特定逻辑。
        /// 目前写了也没用,playfiled没调用
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="c">被打出的卡牌。</param>
        /// <param name="wasOwnCard">是否是己方卡牌。</param>
        /// <param name="triggerEffectMinion">触发此效果的随从。</param>
        public virtual void onCardWasPlayed(Playfield p, CardDB.Card c, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }
        /// <summary>
        /// 本牌在手牌或者为英雄技能时,当卡牌被打出后触发。（重载）。目前写了也没用,playfiled没调用
        /// 子类可以重写此方法，以在卡牌打出后执行特定逻辑。
        /// 目前写了也没用,playfiled没调用
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="c">被打出的卡牌。</param>
        /// <param name="wasOwnCard">是否是己方卡牌。</param>
        /// <param name="triggerhc">触发此效果的卡牌。</param>
        public virtual void onCardWasPlayed(Playfield p, CardDB.Card c, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当激励效果触发时调用。
        /// 子类可以重写此方法，以处理激励效果。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="m">触发激励效果的随从。</param>
        /// <param name="ownerOfInspire">激励效果的拥有者。</param>
        public virtual void onInspire(Playfield p, Minion m, bool ownerOfInspire)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当随从失去圣盾时调用。
        /// 子类可以重写此方法，以处理随从失去圣盾的逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="m">失去圣盾的随从。</param>
        /// <param name="num">失去的圣盾数量。</param>
        public virtual void onMinionLosesDivineShield(Playfield p, Minion m, int num)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 当英雄攻击时触发。
        /// 子类可以重写此方法，以处理英雄攻击时的逻辑。
        /// </summary>
        /// <param name="p">游戏场地对象，包含游戏状态信息。</param>
        /// <param name="own">己方英雄。</param>
        /// <param name="target">攻击目标。</param>
        public virtual void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 执行英雄攻击的操作，并在攻击完成后执行额外的自定义操作。
        /// </summary>
        /// <param name="p">当前的游戏状态（Playfield）对象。</param>
        /// <param name="own">发起攻击的英雄（Minion）对象。</param>
        /// <param name="target">攻击目标的随从（Minion）对象。</param>
        /// <param name="additionalAction">
        /// 在英雄攻击完成后需要执行的额外操作。
        /// 这是一个 Action 委托，可以是任何无参数且无返回值的方法或操作。
        /// </param>
        public void ExecuteHeroAttackWithAction(Playfield p, Minion own, Minion target, System.Action additionalAction)
        {
            // 首先调用当前类的 onHeroattack 方法，执行英雄攻击的默认行为
            this.onHeroattack(p, own, target);

            // 然后检查是否有传入的额外操作
            // 如果有，则调用该额外操作
            if (additionalAction != null)
            {
                additionalAction.Invoke();
            }
        }


        /// <summary>
        /// 当英雄进行攻击时触发的事件处理方法。
        /// 子类可以重写此方法，以在特定的随从或条件下执行自定义的逻辑。
        /// 该方法会在英雄攻击时被调用，并可用于触发基于攻击的效果。
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <param name="triggerMinion">触发此效果的随从。</param>
        /// <param name="target">英雄攻击的目标随从。</param>
        /// <param name="hero">执行攻击的英雄。</param>
        public virtual void onHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }

        /// <summary>
        /// 处理任务完成时触发的效果。
        /// 子类可以重写此方法，以在任务完成时执行特定的逻辑。
        /// </summary>
        /// <param name="p">当前游戏场地，包含游戏状态的信息。</param>
        /// <param name="own">布尔值，指示任务是否由己方完成。true 表示己方完成，false 表示敌方完成。</param>
        public virtual void onQuestCompleteTrigger(Playfield p, bool own)
        {
            // 默认实现为空。子类可以根据需求重写此方法。
            return;
        }


        /// <summary>
        /// 计算并返回发现机制的评分。
        /// 子类可以重写此方法，以根据当前游戏状态自定义发现卡牌的评分逻辑。
        /// 该方法通常用于决定在“发现”机制中选择哪张卡牌。
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <returns>返回一个整数值，表示该卡牌的评分。评分越高，卡牌的优先级越高。</returns>
        public virtual int getDiscoverScore(Playfield p)
        {
            // 默认返回 0 分。子类可以根据需求重写此方法。
            return 0;
        }

        /// <summary>
        /// 使用地标
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <param name="triggerMinion">触发此效果的随从。</param>
        /// <param name="target">指向的的目标随从。</param>
        public virtual void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            return;
        }

        /// <summary>
        /// 使用泰坦技能
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <param name="triggerMinion">泰坦所属的随从对象。</param>
        /// <param name="titanAbilityNO">泰坦的技能编号。</param>
        /// <param name="target">指向的的目标随从。</param>
        public virtual void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            return;
        }
        /// <summary>
        /// 抽到时此牌时触发
        /// </summary>
        /// <param name="p">游戏场地对象，包含当前游戏状态的信息。</param>
        /// <param name="handcard">被抽到卡牌。</param>
        public virtual void castsWhenDrawn(Playfield p, Handmanager.Handcard handcard, bool wasOwnCard)
        {
            return;
        }
    }
}