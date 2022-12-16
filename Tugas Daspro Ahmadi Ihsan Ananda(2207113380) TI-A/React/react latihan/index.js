const iniItems = [
    { index: 1, value: 'Pemrograman Framework', done: false },
    { index: 2, value: 'Pemrograman Visual', done: false },
    { index: 3, value: 'Dasar Pemrograman', done: false },
];

const removeItem = (items, itemIndex) => items.filter((_, i) => i !== itemIndex);

const TodoList = ({ todoItems, removeItem, markDone }) => {
    const itemsNodes = todoItems.map((item, index) => (
        <li key={index} className="list-group-item" onClick={() => markDone(parseInt(index))}>
            <div className={item.done ? 'done' : 'undone'}>
            {item.value}
            <button type="button" className="close" onClick={(e) => {e.stopPropagation();
            removeItem(parseInt(index));} }>&times;</button>
            </div>
        </li>
    ));


return(
    <ul className="list-group">{itemsNodes}</ul>
    );
};

const TodoForm = ({ onTodoAddInputChange, todoAddInput, onSubmit }) => {
    return(
        <form onSubmit={onSubmit} className="form-inline">
            <input 
            autoFocus
            type="text"
            className="form-control"
            placeholder="Masukkan item baru"
            onChange={onTodoAddInputChange}
            value={todoAddInput}
            />
            <button type="submit" className="btn btn-light">Tambah Mata Kuliah</button>
        </form>
    );
};

class TodoApp extends React.Component{
    constructor(props){
        super(props);

        this.state = {
            showMasage: false,
            todoItems: iniItems,
            todoAddInput: '',
        };
    }

addItem = todoItemValue => {
    this.setState(({ todoItems }) => {
        const newItem = {
            value: todoItemValue,
            index: todoItems.length + 1,
            done: false,
        };

        return { todoItems: [newItem].concat(todoItems) }; 
        });
    };

    removeItem = itemIndex => this.setState(({ todoItems }) => 
    ({ todoItems: removeItem(todoItems, itemIndex), 
        showMasage : true, 
    }));

    onSubmit = event => {
        event.preventDefault();
        const { todoAddInput } = this.state;

        if(todoAddInput){
            this.addItem(todoAddInput);
    }

        this.setState({ todoAddInput: '' });
    };

    markDone = itemIndex => {
        this.setState(({ todoItems }) => {
            const itemToMark = todoItems[itemIndex];
            const restItems = removeItem(todoItems, itemIndex);
            itemToMark.done = !itemToMark.done;
            const reformattedItems = itemToMark.done ? restItems.concat(itemToMark) : [itemToMark].concat(restItems);

            return { todoItems: reformattedItems };
        });
    };

    onTodoAddInputChange = event => this.setState({ todoAddInput: event.target.value });

    render(){
        const { todoItems, todoAddInput } = this.state;

        return (
            <div id="main">
                <h1>List Mata Kuliah</h1>
                {this.state.showMasage && <p>Mata Kuliah Berhasil Dihapus</p>}
                <TodoList
                todoItems={todoItems}
                removeItem={this.removeItem}
                markDone={this.markDone}/>
                <TodoForm
                addItem={this.addItem}
                onSubmit={this.onSubmit}
                todoAddInput={todoAddInput}
                onTodoAddInputChange={this.onTodoAddInputChange}/>
            </div>
        );
    }
}

ReactDOM.render(<TodoApp/>,document.getElementById('root'));