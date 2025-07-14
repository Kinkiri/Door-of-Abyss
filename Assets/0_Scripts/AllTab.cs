// 所有标签都在这里定义
/// <summary>
/// 卡牌类型：
/// 魔法卡、单位卡、装备卡、场地卡、特殊卡
/// </summary>
public enum CardType { 魔法, 单位, 装备, 场地, 特殊 }

/// <summary>
/// 单位类型：
/// 兵种、建筑
/// </summary>
public enum UnitType { 兵种, 建筑 }

/// <summary>
/// 稀有度：
/// 初级、中级、高级、顶级
/// </summary>
public enum Rarity { 初级, 中级, 高级, 顶级 }

public enum TargetType { 无, 单位, 路线, }
public enum TargetRange { 任意, 我方, 敌方, }
/// <summary>
/// 世界标签：
/// 曼斯维森
/// </summary>

public enum WorldTab{ 无, 地球, 曼斯维森, }

/// <summary>
/// 势力标签
/// 擢升之手、圣主教
/// </summary>
public enum ForceTab { 无, 制作组, 擢升之手, 圣主教, }
/// <summary>
/// 元素：
/// 水、火、土、电、毒
/// </summary>
public enum Element { 无, 水, 火, 土, 电, 毒, }


/// <summary>
/// 通用标签：
/// </summary>
public enum NormalTab { 科技, 宗教 }
