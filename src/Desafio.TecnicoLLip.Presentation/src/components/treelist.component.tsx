import { Component } from "react";
import ProjectService from "../services/project.service";
import Treelista from "./treelisttasks";

type Props = {};

type Projects = { id: number, titulo: string, descricao: string, dataCriacao: Date };

type State = { data: Array<Projects>, redirect: string | null };

export default class TreeList extends Component<Props, State> {
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
          // rome-ignore lint/complexity/useOptionalChain: <explanation>
(error.response &&
            error.response.data &&
            error.response.data.message) ||
          error.message ||
          error.toString();     
          console.log('error:',resMessage);   
      }
    );
  }

  render() {
    return (
      <Treelista/>          
    );
  }
}