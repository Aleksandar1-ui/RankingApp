import Item from './Item.js';
const ItemCollection = ({ items, drag, imageArr }) => {
    return (
        <div className="items-not-ranked">
            {
                items.map((item) => (item.ranking === 0)
                    ? <Item key={`item-${item.id}`} item={item} drag={drag}
                        itemImgObj={imageArr.find(o => o.id === item.imageId)} />
                    : null)
            }
        </div>
        )
}
export default ItemCollection;