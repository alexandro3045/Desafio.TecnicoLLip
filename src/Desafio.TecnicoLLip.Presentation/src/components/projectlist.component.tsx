import { Component } from "react";
import ProjectService from "../services/project.service";

import Paper from '@mui/material/Paper';
import {
  TreeDataState,
  CustomTreeData,
} from '@devexpress/dx-react-grid';
import {
  Grid,
  Table,
  TableHeaderRow,
  TableTreeColumn,
} from '@devexpress/dx-react-grid-material-ui';

//import {
//  generateRows,
//  defaultColumnValues,
//} from '../../../demo-data/generator';
//const getChildRows = (row, rootRows) => (row ? row.items : rootRows);

type Props = {};

type Projects = { id: number, titulo: string, descricao: string, dataCriacao: Date };

type State = { data: Array<Projects>, redirect: string | null };





export default class ProjectList extends Component<Props, State> {
  constructor(props: Props) {

    super(props);

      this.handleRegister();

      this.state = { data: [], redirect: null };

  }

  handleRegister() {

      ProjectService.listar()
          .then(response => {
              if (response) {
                this.setState({
                    data: response.data
                });
            }
      },
      error => {
        const resMessage =
          (error.response &&
            error.response.data &&
            error.response.data.message) ||
          error.message ||
          error.toString();        
      }
    );
  }

  render() {
    const { data } = this.state;
      
    return (
      <div className="col-md-12">
            <div className="card card-container"> 
                <table>
                    <tr>
                        <td>
                            <button onClick={e => window.location.href = '/project'}>Novo</button>
                        </td>
                    </tr>
                </table> 
                <table>
                    <tr>
                        <td>T�tulo</td>
                        <td>Descri��o</td>
                        <td>Data de Cria��o</td>
                    </tr>
                </table> 
                {data.map((reg, index) => {
                return (
                    <div key={index}>
                        <table>
                            <tr>
                                <td>{reg.titulo}</td>
                                <td>{reg.descricao}</td>
                                <td>{reg.dataCriacao.toString()}</td>
                                <td>
                                    <button onClick={e => window.location.href='/project'}>Tarefas</button>
                                </td>
                            </tr>
                        </table>
                    </div>
                );
            })}       
        </div>
      </div>
    );
  }
}
